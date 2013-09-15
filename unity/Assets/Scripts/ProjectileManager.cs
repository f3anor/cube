using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class ProjectileManager : MonoBehaviour
{
    /*
	
    can be launched
        "A Projectile can be launched at random times at 4 different locations."
    can be traveling
        "A Projectile travels along one axis, heading towards the cube."
    can die
        "A Projectile dies, if it didn't hit either one of the Cube Segments on its (the Proectiles) axis OR if it hits another Projectile.
    can hit a [Cube Segment]
        ...
		
    */

    public bool spawnProjectiles = true;
    public List<GameObject> activeProjectiles = new List<GameObject>(); //a list that registers which projectiles are currently active	
    public Transform[] startPositions; //the positions from where projectiles are launched from
    public GameObject projectile; //the type of projectile = prefab in this case that gets launced


    public int[] SpawningSchedule;

    public int[] SpawningScheduleSpeeds;

    public int[] SpawningScheduleIntervals;

    public bool scheduledSpawning = true;

    public int schedulePosition = 0;


    public float spawnInterval = 5.0f; //the interval within which projectiles are spawned; "spawn a projectile every spawnInterval seconds".
    public float rndSpeedLower = 1.0f; //lower amount of random speed of to the launched projectile
    public float rndSpeedUpper = 5.0f; //upper amount of random speed of the launched projectile

    public float rndSpawnIntervalLower = 0.5f;
    public float rndSpawnIntervalUpper = 3.0f;

    // "launch a projectile every 5 (=spawnInterval) seconds, with a speed between 1.0f (=rndSpeedLower) and 5.0f (=rndSppedUpper)



    private uint projectilesCounter = 0; //keeps track of how many projectiles have been instantiated

    private EventManager _eventManager;


    void Start()
    {
        _eventManager = EventManager.getInstance();

        _eventManager.addListener(ProjectileManager_OnProjectileToBoundCollision, EventManager.eventName.OnProjectileToBoundCollision);
        _eventManager.addListener(ProjectileManager_OnProjectileToSegment, EventManager.eventName.OnProjectileToSegmentCollision);
        _eventManager.addListener(ProjectileManager_OnProjectileToProjectile, EventManager.eventName.OnProjectileToProjectileCollision);
        _eventManager.addListener(ProjectileManager_OnProjectileTrapped, EventManager.eventName.OnProjectileTrapped);
    }

    private void ProjectileManager_OnProjectileTrapped(GameObject g, EventArgs e) {
        removeProjectileFromGame(g);
    }

    private void ProjectileManager_OnProjectileToBoundCollision(GameObject g, EventArgs e)
    {
        removeProjectileFromGame(g);
    }

    private void ProjectileManager_OnProjectileToSegment(GameObject g, EventArgs e)
    {
        disableAllProjectiles();
        removeProjectileFromGame(g);
    }

    private void ProjectileManager_OnProjectileToProjectile(GameObject g, EventArgs e)
    {
        removeProjectileFromGame(g);
    }

    private void removeProjectileFromGame(GameObject g)
    {
        activeProjectiles.Remove(g);
        Destroy(g);
    }


    public IEnumerator spawnProjectile()
    {

        if (schedulePosition >= SpawningSchedule.Length)
        {
            scheduledSpawning = false;
        }
        else
        {
            scheduledSpawning = true;
        }

        while (spawnProjectiles) //TODO why do i actually need this loop?
        {
            //select a position to launch projectile from (at random)
            if (!scheduledSpawning || schedulePosition >= SpawningSchedule.Length)
            {
                spawnRandomProjectile();
            }
            else
            {
                spawnScheduledProjectile();
            }





            yield return new WaitForSeconds(spawnInterval); //launch another projectile when interval-time has passed
        }
    }

    private void spawnRandomProjectile()
    {

        spawnInterval = UnityEngine.Random.Range(rndSpawnIntervalLower, rndSpawnIntervalUpper);
        int location = (int)UnityEngine.Random.Range(0, 4); //choose a location from which to launch a projectile from at random (int gets fed into startPositions-list (1,3) for B-C-Lane only
        GameObject instantiatedProjectile = Instantiate(projectile, startPositions[location].transform.position, startPositions[location].transform.rotation) as GameObject;
        instantiatedProjectile.name = "msh_instantiatedProjectile_" + projectilesCounter.ToString();
        instantiatedProjectile.GetComponent<Projectile>().speedModifier = UnityEngine.Random.Range(rndSpeedLower, rndSpeedUpper);
        projectilesCounter++;

        //register instantiated projectile
        registerNewInstance(instantiatedProjectile);
    }

    private void spawnScheduledProjectile()
    {
        int location = SpawningSchedule[schedulePosition];
        spawnInterval = SpawningScheduleIntervals[schedulePosition];

        GameObject instantiatedProjectile = Instantiate(projectile, startPositions[location].transform.position, startPositions[location].transform.rotation) as GameObject;
        instantiatedProjectile.name = "msh_instantiatedProjectile_" + projectilesCounter.ToString();
        instantiatedProjectile.GetComponent<Projectile>().speedModifier = SpawningScheduleSpeeds[schedulePosition];
        projectilesCounter++;

        //register instantiated projectile
        registerNewInstance(instantiatedProjectile);
        schedulePosition++;

    }

    private void registerNewInstance(GameObject projectileToRegister)
    {
        activeProjectiles.Add(projectileToRegister); //adds projectile to the active-projectiles-list (List<GameObject> activeProjectiles)
    }

    public List<GameObject> getActiveProjectiles()
    {
        return activeProjectiles;
    }

    public void removeAllProjectiles()
    {

        //destroy every registered game object within the activeProjectiles list
        foreach (GameObject projectile in activeProjectiles)
        {
            Destroy(projectile.GetComponent<Projectile>().gameObject);
        }

        //clear the list
        activeProjectiles.Clear();
    }

    public void disableAllProjectiles()
    {
        //disable every registered game object within the activeProjectiles list, this is a quirk that is needed because of delayed removal made  necessary so that sounds can finish playing
        foreach (GameObject projectile in activeProjectiles)
        {
            projectile.GetComponent<Projectile>().disableProjectile();
        }
    }


}
