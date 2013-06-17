//UnityEditorInternal.InternalEditorUtility.tags <-- accesses available tags in unity
using UnityEngine;
using System;
using System.Collections;

public class Projectile : MonoBehaviour
{


    //audio-clips for all projectile related operations, which clips are used can be definied in the unity editor by dragging them into the specific slots

    public float speedModifier = 2.0f; //determins how fast the projectile moves by multiplying this value with a forward vector and deltaTime

    public EventManager _eventManager;

    // Use this for initialization
    void Start()
    {
        _eventManager = EventManager.getInstance();
        setUpOrientation();
    }

    // Update is called once per frame
    void Update()
    {

        move();
    }

    private void setUpOrientation()
    {
        //orient projectile so that they move toward the middle when +z is their forward direction
        transform.LookAt(new Vector3(0, transform.position.y, 0));
    }

    private void move()
    {
        /*translate the object using a vector-multiplication with a forward-vector (0,0,1) - multiplied with the speedModifier to make it faster/slower
        translation occurs in object space (Space.Self) */
        transform.Translate(Vector3.forward * speedModifier * Time.deltaTime, Space.Self);

    }

    private void OnTriggerEnter(Collider collidedWith)
    {
        handleCollisions(collidedWith);
        _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectileCollision);

    }

    private void handleCollisions(Collider collidedWith)
    {

        //check out with what kind of object the projectile collided

        if (collidedWith.CompareTag("bound")) //if collided with bound remove projectile from the game, since out of bounds
        {
            _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectileToBoundCollision);
        }


        if (collidedWith.CompareTag("segment")) //if the projectile collided with a (cube-) segment
        {
            _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectileToSegmentCollision);

        }


        if (collidedWith.CompareTag("projectile")) //remove the projectile once it collided with another projectile
        {
            _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectileToProjectileCollision);
        }

    }


    public void disableProjectile()
    {
        //quirk so that audio can still be played while object visually and functionally removed
        this.renderer.enabled = false;
        this.collider.enabled = false;

    }



}
