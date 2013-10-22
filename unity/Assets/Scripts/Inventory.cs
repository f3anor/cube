using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
public class Inventory : MonoBehaviour {
    
    public static int inventorySize = 3;
    
    public List<GameObject> guiSlots = new List<GameObject>(inventorySize);
    public List<GameObject> freeGuiSlots = new List<GameObject>(inventorySize);

    public Dictionary<GameObject, PowerUp> slotPowerupDict = new Dictionary<GameObject,PowerUp>();
    
    private EventManager _eventManager;

	// Use this for initialization
	void Start () {
        _eventManager = EventManager.getInstance();

        setupInventorySlots();
        
        _eventManager.addListener(inventory_onInventorySlotClicked, EventManager.eventName.OnInventorySlotClicked);
        _eventManager.addListener(Inventory_OnProjectilePowerupToSegmentCollision, EventManager.eventName.OnProjectilePowerupPickedUp);
        _eventManager.addListener(Inventory_OnRestartLoss, EventManager.eventName.OnRestartLoss);
	}

    private void Inventory_OnRestartLoss(GameObject g, EventArgs e)
    {

        freeGuiSlots.Clear();

        foreach (GameObject guiSlot in guiSlots)
        {
            guiSlot.GetComponent<InventorySlot>().resetMaterial();
            freeGuiSlots.Add(guiSlot);
        }
        slotPowerupDict.Clear();
        Debug.Log("Inventory_OnRestartLoss");
    }



    private void Inventory_OnProjectilePowerupToSegmentCollision(GameObject g, EventArgs e)
    { 
        addPowerUp(g.GetComponent<PowerUp>());
    }



    private void setupInventorySlots()
    {
        foreach (GameObject slot in guiSlots)
        {
            freeGuiSlots.Add(slot);
            slot.AddComponent<InventorySlot>();
            slot.AddComponent<BoxCollider>().isTrigger = true;
        }
    }
	
	// Update is called once per frame
    void Update()
    {
	
	}

    private void inventory_onInventorySlotClicked(GameObject go, EventArgs ea)
    {
        
        activatePowerup(go);
        removePowerUp(go);
    }

    private void activatePowerup(GameObject go)
    {
        PowerUp foundPowerup;
        if (slotPowerupDict.TryGetValue(go, out foundPowerup) && freeGuiSlots.Count < inventorySize)
        {
            go.GetComponent<InventorySlot>().resetMaterial();
            foundPowerup.activate();
        }
    }

    public void addPowerUp(PowerUp powerUp)
    {

        //Debug.Log("adding " + powerUp + " to slot: " + slot);
        if (freeGuiSlots.Count > 0)
        {
            slotPowerupDict.Add(freeGuiSlots[0], powerUp);
            freeGuiSlots[0].GetComponent<InventorySlot>().setMaterial(powerUp.powerupGUIMaterial);
            freeGuiSlots.Remove(freeGuiSlots[0]);
            
        }
    }

    public void removePowerUp(GameObject slot)
    {
        if (freeGuiSlots.Count < inventorySize)
        {
            slotPowerupDict.Remove(slot);
            freeGuiSlots.Add(slot);
        }
    }



}
