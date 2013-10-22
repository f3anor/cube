using UnityEngine;
using System.Collections;

public class SlowMissilesPowerUp : OverTimePowerUp {



	// Use this for initialization
	void Start () {
      //  Debug.Log("SlowMissilesPowerUp instantiated");
        powerUpActivationEvent = EventManager.eventName.OnPowerUpSlowMissilesActivated;
        powerUpDeactivationEvent = EventManager.eventName.OnPowerUpSlowMissilesDeactivated;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
