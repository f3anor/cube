using UnityEngine;
using System;

public class MultiplicatorPowerUp : OverTimePowerUp {

    public int mutliplicationFactor = 3;
    

	// Use this for initialization
	void Start () {
        powerUpActivationEvent = EventManager.eventName.OnPowerUpMultiplicatorActivated;
        powerUpDeactivationEvent = EventManager.eventName.OnPowerUpMultiplicatorDepleted;
	}



}
