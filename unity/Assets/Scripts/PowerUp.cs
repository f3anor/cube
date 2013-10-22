using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public abstract class PowerUp : MonoBehaviour
{
    public Material powerupGUIMaterial;
    protected string _name = "default";
    protected EventManager _eventManager;
    protected GameObject _go;
    protected EventManager.eventName powerUpActivationEvent;


    void Awake()
    {
        _eventManager = EventManager.getInstance();
        _go = this.gameObject;
        powerUpActivationEvent = EventManager.eventName.OnPowerUpMultiplicatorActivated;
    }


    virtual public void activate()
    {
        //fire activation event
        _eventManager.dispatchEvent(_go, EventArgs.Empty, powerUpActivationEvent);
    }

}
