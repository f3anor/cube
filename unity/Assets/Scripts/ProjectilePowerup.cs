using UnityEngine;
using System;
using System.Collections;

public class ProjectilePowerup : Projectile {


    protected override void handleCollisions(Collider collidedWith)
    {

        //check out with what kind of object the projectile collided

        if (collidedWith.CompareTag("bound")) //if collided with bound remove projectile from the game, since out of bounds
        {
            _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectilePowerupToBoundCollision);
            Debug.Log("powerup collided with bound");
        }


        if (collidedWith.CompareTag("segment")) //if the projectile collided with a (cube-) segment
        {
            _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectilePowerupPickedUp);
            Debug.Log("powerup collided with segment");
        }


        if (collidedWith.CompareTag("projectile")) //remove the projectile once it collided with another projectile
        {
            _eventManager.dispatchEvent(this.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectilePowerupToProjectileCollision);
            Debug.Log("powerup collided with missile");
        }

    }

    protected override void move()
    {

        transform.Translate(Vector3.forward * speedModifier * Time.deltaTime, Space.Self);

    }

}
