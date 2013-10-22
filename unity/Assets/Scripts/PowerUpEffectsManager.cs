using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class PowerUpEffectsManager : MonoBehaviour {

    private EventManager _eventManager;
    private GameManager _gameManager;

    public int MultiplicatorPowerUp_MultplicationFactor = 3;

    List<Projectile> slowedProjectiles = new List<Projectile>();

	void Start () {

        _eventManager = EventManager.getInstance();
        _gameManager = GameManager.getInstance();

        
        //listen to all powerup-events
        _eventManager.addListener(PowerUpEffectsManager_onPowerUpMultiplicatorActivated, EventManager.eventName.OnPowerUpMultiplicatorActivated);
        _eventManager.addListener(PowerUpEffectsManager_onPowerUpMultiplicatorDepleted, EventManager.eventName.OnPowerUpMultiplicatorDepleted);
        _eventManager.addListener(PowerUpEffectsManager_onPowerUpTransmute, EventManager.eventName.OnPowerUpTransmute);
        _eventManager.addListener(PowerUpEffectsManager_onPowerUpSlowMissilesActivated, EventManager.eventName.OnPowerUpSlowMissilesActivated);
        _eventManager.addListener(PowerUpEffectsManager_onPowerUpSlowMissilesDeactivated, EventManager.eventName.OnPowerUpSlowMissilesDeactivated);


	}




    void PowerUpEffectsManager_onPowerUpMultiplicatorActivated(GameObject g, EventArgs e)
    {
        Debug.Log(g);
        //MultiplicatorPowerUp powerupObject = g.GetComponent<MultiplicatorPowerUp>(); //dont ask projectiles you already killed; if individual amount of point-multiplication should ever be necessary pass that in eventargs ...

        _gameManager.pointsMultiplier = MultiplicatorPowerUp_MultplicationFactor;
        Debug.Log("PEM carrying out PowerUpEffectsManager_onPowerUpMultiplicatorActivated");
    }


    void PowerUpEffectsManager_onPowerUpMultiplicatorDepleted(GameObject g, EventArgs e)
    {
        _gameManager.pointsMultiplier = 1; //set back  to initial value; attention: 1 = hardcoded value, which is assumed to be the normal value for point calculation
        Debug.Log("PEM carrying out ONPOWERUPDEPLETED");
    }

    void PowerUpEffectsManager_onPowerUpSlowMissilesActivated(GameObject g, EventArgs e)
    {
        Debug.Log("PEM carrying out PowerUpEffectsManager_onPowerUpSlowMissilesActivated");

       List<GameObject> allProjectiles =  _gameManager.projectileManager.getActiveProjectiles();

       foreach (GameObject missile in allProjectiles)
       {
           Debug.Log("doing the stuff");
           Projectile missileComponent = missile.GetComponent<Projectile>();
           missileComponent.speedModifier *= 0.3f; //attention: 0.3 = hardcoded value; figure out in balancing and store in variable
           slowedProjectiles.Add(missileComponent);
       }

        
    }


    void PowerUpEffectsManager_onPowerUpSlowMissilesDeactivated(GameObject g, EventArgs e)
    {

        foreach (Projectile missileComponent in slowedProjectiles)
        {
            missileComponent.speedModifier = 1;
        }
        slowedProjectiles.Clear();
        Debug.Log("PEM carrying out PowerUpEffectsManager_onPowerUpSlowMissilesDeactivated");
    }



    void PowerUpEffectsManager_onPowerUpTransmute(GameObject g, EventArgs e)
    {
        int pointsForAllActiveMissiles = _gameManager.projectileManager.getActiveProjectiles().Count * 5; //5 = hardcoded value for points --> figure out in balancing and store in variable
        _gameManager.projectileManager.removeAllProjectiles();
        _gameManager.increasePoints(pointsForAllActiveMissiles);
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //mpu.activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            //tpu.activate();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //spu.activate();
        }

	

    }


}
