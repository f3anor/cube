using UnityEngine;
using System;
using System.Timers;

public class TransmutePowerUp : PowerUp {


    void Start ()
    {
        powerUpActivationEvent = EventManager.eventName.OnPowerUpTransmute;
    }
    
    override public void activate()
    {
        base.activate();
    }
}
