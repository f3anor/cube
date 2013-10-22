using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class SoundManager : MonoBehaviour
{

    public AudioClip restartSound;
    public AudioClip victorySound;

    public AudioClip music;

    public AudioClip foldSound;
    public AudioClip unfoldSound;
    public AudioClip hoverSound;
    public AudioClip outSound;
    public AudioClip trappedSound;

    public AudioClip collisionSound;
    public AudioClip projectileCollisionSound;

    public AudioClip powerUpPickedUpSound;

    public AudioClip inventorySlotClicked;

    private static SoundManager instance;
    private EventManager _eventManager;
    private GameManager _gameManager;


    private SoundManager()
    {
        _eventManager = EventManager.getInstance();
        _eventManager.addListener(soundManager_OnProjectileToSegmentCollision, EventManager.eventName.OnProjectileToSegmentCollision);
        _eventManager.addListener(soundManager_OnProjectileToProjectileCollision, EventManager.eventName.OnProjectileToProjectileCollision);
        _eventManager.addListener(soundManager_OnFoldingStarted, EventManager.eventName.OnFoldingStarted);
        _eventManager.addListener(soundManager_OnFoldedOut, EventManager.eventName.OnFoldedOut);
        _eventManager.addListener(soundManager_OnFoldedInward, EventManager.eventName.OnFoldedInward);
        _eventManager.addListener(soundManager_OnSegmentHover, EventManager.eventName.OnSegmentHover);
       // _eventManager.addListener(soundManager_OnRestart, EventManager.eventName.OnRestart);
        _eventManager.addListener(soundManager_OnRestartWin, EventManager.eventName.OnRestartWin);
        _eventManager.addListener(soundManager_OnProjectileTrapped, EventManager.eventName.OnProjectileTrapped);

        _eventManager.addListener(soundManager_OnInventorySlotHover, EventManager.eventName.OnInventorySlotHover);
        _eventManager.addListener(soundManager_OnInventorySlotClicked, EventManager.eventName.OnInventorySlotClicked);
        _eventManager.addListener(soundManager_OnProjectilePowerupPickedUp, EventManager.eventName.OnProjectilePowerupPickedUp);
        
    }

    private void soundManager_OnProjectilePowerupPickedUp(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(powerUpPickedUpSound, g.transform.position);
    }

    void soundManager_OnProjectileTrapped(GameObject g, EventArgs e) {
        AudioSource.PlayClipAtPoint(trappedSound, g.transform.position);
    }


    public static SoundManager getInstance()
    {
        if (instance == null)
        {
            instance = (SoundManager)FindObjectOfType(typeof(SoundManager));
        }
        return instance;
    }

    void Start()
    {
        AudioSource.PlayClipAtPoint(music, new Vector3(0, 8, 0), 0.1f);
    }

    private void soundManager_OnProjectileToSegmentCollision(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(collisionSound, g.transform.position);
    }

    private void soundManager_OnProjectileToProjectileCollision(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(projectileCollisionSound, g.transform.position);
    }

    private void soundManager_OnFoldingStarted(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(foldSound, g.transform.position);
    }

    private void soundManager_OnFoldedOut(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(unfoldSound, g.transform.position);
    }

    private void soundManager_OnFoldedInward(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(outSound, g.transform.position);
    }

    private void soundManager_OnSegmentHover(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(hoverSound, g.transform.position);
    }

    private void soundManager_OnRestartWin(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(victorySound, g.transform.position);
    }

    private void soundManager_OnInventorySlotHover(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(outSound, g.transform.position);
    }


    private void soundManager_OnInventorySlotClicked(GameObject g, EventArgs e)
    {
        AudioSource.PlayClipAtPoint(inventorySlotClicked, g.transform.position);
    }
}
