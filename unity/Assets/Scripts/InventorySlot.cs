using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class InventorySlot : MonoBehaviour {



     private EventManager _eventManager;
     public Color overColor = new Color(1.0f, 0.678f, 0.10f, 0.7f);
     public Color initialColor = new Color(0.157f, 0.157f, 0.157f, 1.0f);
     public Color clickColor = new Color(1.0f, 0.881f, 0.13f, 0.7f);

     private bool _isOccupied = false;
     private bool _mouseOver = false;

     private Material initialMaterial;

     private Material hoverstate;
     private Material clickstate;

	// Use this for initialization
	void Start () {
        _eventManager = EventManager.getInstance();
        initialMaterial = this.GetComponentInChildren<Renderer>().material;
        checkIfColorIsSet();
	}

    public void setMaterial(Material m)
    {
        this.GetComponentInChildren<Renderer>().material = m;
    }

    public void resetMaterial()
    {
        this.GetComponentInChildren<Renderer>().material = initialMaterial;
    }


    private void checkIfColorIsSet()
    {
        if (initialColor != null)
        {
            this.GetComponentInChildren<Renderer>().material.color = initialColor;
        }
        else
        {
            initialColor = this.GetComponentInChildren<Renderer>().material.color;
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseOver()
    { 

        if (Input.GetMouseButtonDown(0))
        {
            this.GetComponentInChildren<Renderer>().material.color = clickColor;
            _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnInventorySlotClicked);
            StartCoroutine(mouseClickEffect(0.15f));
        }



    }

    void OnMouseEnter()
    {
        //change material
        this.GetComponentInChildren<Renderer>().material.color = overColor;
        _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnInventorySlotHover);
        _mouseOver = true;



    }



    void OnMouseExit()
    {
        this.GetComponentInChildren<Renderer>().material.color = initialColor;
        _mouseOver = false;
    }


    private IEnumerator mouseClickEffect(float waitForSeconds)
    {
        
        
        yield return new WaitForSeconds(waitForSeconds);
        if(_mouseOver) this.GetComponentInChildren<Renderer>().material.color = overColor;
    }



}
