using UnityEngine;
using System;

public class TrappingZone : MonoBehaviour {

    private GameManager _gameManager;
    private EventManager _eventManager;

	// Use this for initialization
	void Start () {
        _gameManager = GameManager.getInstance();
        _eventManager = EventManager.getInstance();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerStay(Collider c) {
        if (checkForTrapping()) {
            _eventManager.dispatchEvent(c.gameObject, EventArgs.Empty, EventManager.eventName.OnProjectileTrapped);
        }
}
    

    private bool checkForTrapping() {
        if (_gameManager.segmentsFolded == 4)
        {
            return true;
        }
        else {
            return false;
        }
    }
}
