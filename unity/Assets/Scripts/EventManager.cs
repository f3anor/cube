using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public delegate void GameEvent(GameObject g, EventArgs e);

public class EventManager
{

    private static EventManager Instance;



    /* Events
    private event GameEvent OnSegmentHover;
    private event GameEvent OnFoldingStarted;
    private event GameEvent OnFoldingDone;
    private event GameEvent OnFolded;
    private event GameEvent OnFoldedOut;
    private event GameEvent OnFoldedInward;

    private event GameEvent OnProjectileCollision;
    private event GameEvent OnProjectileToBoundCollision;
    private event GameEvent OnProjectileToSegmentCollision;
    private event GameEvent OnProjectileToProjectileCollision;

    private event GameEvent OnRestart; */

    public enum eventName
    {
        OnSegmentHover,
        OnFoldingStarted,
        OnFoldingDone,
        OnFolded,
        OnFoldedOut,
        OnFoldedInward,
        OnProjectileCollision,
        OnProjectileToBoundCollision,
        OnProjectileToSegmentCollision,
        OnProjectileToProjectileCollision,
        OnProjectileTrapped,
        OnRestart,
        OnRestartLoss,
        OnRestartWin
    }

    private Dictionary<eventName, GameEvent> eventDictionary = new Dictionary<eventName, GameEvent>();




    private EventManager()
    {

        var tmpAllEvents = Enum.GetValues(typeof(eventName));

        foreach (eventName evt in tmpAllEvents)
        {
            eventDictionary.Add(evt, null);
        }

    }




    public static EventManager getInstance()
    {
        if (Instance == null)
        {
            Instance = new EventManager();
        }
        return Instance;
    }

    public void addListener(GameEvent gameEvt, eventName evtName)
    {
        eventDictionary[evtName] += gameEvt;
    }

    public void dispatchEvent(GameObject obj, EventArgs e, eventName evtName)
    {

        if (eventDictionary[evtName] != null)
        {
            eventDictionary[evtName].Invoke(obj, e);
        }
    }


}
