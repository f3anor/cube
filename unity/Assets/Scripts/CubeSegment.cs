using UnityEngine;
using System;
using System.Collections;

public class FoldingEventArgs : EventArgs {
    
    public Enum currentState;
    public Enum previousState;

    public FoldingEventArgs(Enum currentState, Enum previousState)
    {
        this.currentState = currentState;
        this.previousState = previousState;
    }
}

public class CubeSegment : MonoBehaviour
{
    /*
	
    can be folded in/increase [Cube] complete

	
    can be folded out/increase [Cube] incomplete

	
    can be in "Rising-Up-Process"
        "Rising-Up occurs in x time."
	
    can be in "Folding-Back-Process"
        "Folding-Back occurs in x time."
	
    can be hit by a [Projectile]
	
    */

    //audio-clips for all chooseFoldingOperation operations, which clips are used can be definied in the unity editor by dragging them into the specific slots


    public bool segmentCrashed = false; //saves if a crash had just occured, in order to stop further chooseFoldingOperation-operations
    public float animSpeed = 3.0f; //the amount of multiplication of deltaTime at which a cube-segment finishes a chooseFoldingOperation-operation


    private Color startColor; //color of cubesegments at start
    private Color overColor = new Color(1.0f, 0.678f, 0.10f, 0.7f); //color for cube-segments on mouseover

    static int inwardFoldedSegments = 0;
    static int maxNumberOfInwardFoldedSegments = 1;

    public event GameEvent onFolding; //define event-type and event-name TODO: temp

    

    private EventManager _eventManager;
    private GameManager _gameManager;


    public float testProgress = 0;

    public enum SegmentStates
    {
        Folded,
        Folded_out,
        Folded_inward,
        Transitioning
    }

    public SegmentStates previousState;
    public SegmentStates currentState;


    void Start()
    {

        _eventManager = EventManager.getInstance();
        _gameManager = GameManager.getInstance();

        currentState = SegmentStates.Folded_out;
        startColor = GetComponentInChildren<Renderer>().material.color; //TODO get start color from material, because the color-picker is a pita... #!
    }




    public void chooseFoldingOperation(bool inward) //chooseFoldingOperation-function, gets called when player clicks on a cube-segment
    {

        switch (currentState)
        {

            case SegmentStates.Transitioning:
                if (!_gameManager.allowClickWhileTransitioning)
                {
                    Debug.Log("clicking while transitioning not allowed.");
                    break;
                }
                else
                {
                    StopAllCoroutines();
                    goto case SegmentStates.Folded;
                }

            case SegmentStates.Folded:
                if (inward && inwardFoldingLegit())
                {
                    foldInward();
                    inwardFoldedSegments++;
                }
                else if (!inward)
                {
                    foldOut();

                }
                break;

            case SegmentStates.Folded_out:
                fold();
                break;

            case SegmentStates.Folded_inward:
                fold();
                inwardFoldedSegments--;
                break;

            default:
                break;
        }


    }


    private void foldSegmentToAngle(float toAngle, SegmentStates newState, bool changeStateRightAway = false) // chooseFoldingOperation coroutine, which folds cube-segments in or out, time specified in animSpeed-attribute
    {
        //TODO: true/false flag to specify if state should be changed before or after anim?
        //TODO: flag for animation on/off, so that i could use this function in reset() as well? more dry?
        if (currentState != SegmentStates.Transitioning)
        {
            previousState = currentState;
        } 
        currentState = SegmentStates.Transitioning;

        if (!changeStateRightAway)
        {
            StartCoroutine(
                animator(transform, toAngle, false, () => {
                    if (currentState != SegmentStates.Transitioning)
                    {
                        previousState = currentState;
                    }
                    currentState = newState;
                    _eventManager.dispatchEvent(this.gameObject, new FoldingEventArgs(currentState, previousState), EventManager.eventName.OnFolded);
                })
                );

        }
        else
        {
            if (currentState != SegmentStates.Transitioning)
            {
                previousState = currentState;
            }
            currentState = newState;
            StartCoroutine(animator(transform, toAngle, false));
        }



    }






    private IEnumerator animator(Transform transformToAnimate, float targetValueToAnimateTo, bool cancel, Action optionalFunc = null) //TODO don't quite get how this works - why don't i need a member-variable for it work, like a did before?
    {

        float startValue = transformToAnimate.eulerAngles.z;
        float progress = 0.0f;  // float that keeps track of the animation-process	
        float currentValue = 0.0f; // temporary storeage for current value

        while (progress < 1.0f && !cancel) // loop which executes till progress is 1, aka "animation" done
        {
            currentValue = Mathf.Lerp(startValue, targetValueToAnimateTo, progress); // linear interpolate from current rotation to desired final rotation
            transformToAnimate.eulerAngles = new Vector3(transformToAnimate.eulerAngles.x, transformToAnimate.eulerAngles.y, currentValue); //apply transformations
            yield return new WaitForEndOfFrame(); // wait until frame is done, than reiterate thru loop
            progress += Time.deltaTime * animSpeed; // increase progress
        }

        transformToAnimate.eulerAngles = new Vector3(transformToAnimate.eulerAngles.x, transformToAnimate.eulerAngles.y, targetValueToAnimateTo);

        if (optionalFunc != null)
        {
            //Debug.Log("executing function...");
            optionalFunc();
        }
    }

    private void foldOut()
    {
        foldSegmentToAngle(0f, SegmentStates.Folded_out, true);
        _eventManager.dispatchEvent(this.gameObject, new FoldingEventArgs(currentState, previousState), EventManager.eventName.OnFoldedOut);
    }

    private void fold()
    {
        foldSegmentToAngle(90f, SegmentStates.Folded);
        _eventManager.dispatchEvent(this.gameObject, new FoldingEventArgs(currentState, previousState), EventManager.eventName.OnFoldingStarted);
    }

    private void foldInward()
    {
        foldSegmentToAngle(170f, SegmentStates.Folded_inward, true);
        _eventManager.dispatchEvent(this.gameObject, new FoldingEventArgs(currentState, previousState), EventManager.eventName.OnFoldedInward);

    }

    public void reset()
    {
        // a reset-function which imedeatly resets the cube segments position to the initial state, gets called up by GameManager's game over method
        inwardFoldedSegments = 0;
        currentState = SegmentStates.Folded_out;
        segmentCrashed = false;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, 0);
    }

    private bool inwardFoldingLegit()
    {
        return inwardFoldedSegments < maxNumberOfInwardFoldedSegments ? true : false;
    }


    // handle mouse-input
    public void OnMouseOver()
    {
        if (GameManager.getInstance().getControlState())
        {
            if (Input.GetMouseButtonDown(0))
            {
                chooseFoldingOperation(false); //call chooseFoldingOperation-function to fold in, once player clicked on a cube-segment with the RMB, thusly initiiating chooseFoldingOperation/unfolding process
            }

            if (Input.GetMouseButtonDown(1))
            {
                chooseFoldingOperation(true); //call chooseFoldingOperation-function once player clicked on a cube-segment, thusly initiiating chooseFoldingOperation/unfolding process
            }

        }
    }

    public void OnMouseEnter()
    {
        _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnSegmentHover);
        this.GetComponentInChildren<Renderer>().material.color = overColor;
    }

    public void OnMouseExit()
    {
        this.GetComponentInChildren<Renderer>().material.color = startColor; //reset color once player moved cursor off segment
    }

}
