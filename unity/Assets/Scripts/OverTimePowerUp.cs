using UnityEngine;
using System;
using System.Timers;

public abstract class OverTimePowerUp : PowerUp
{
    private Timer _timer;
    private uint _durationInMs = 4000;
    private bool _isActive = false;
    protected EventManager.eventName powerUpDeactivationEvent;





    override public void activate()
    {
        base.activate();
        setupTimer();
    }

    private void setupTimer()
    {
        _timer = new Timer(_durationInMs);
        _timer.Enabled = true;
        _isActive = true;
        _timer.Elapsed += new ElapsedEventHandler(onTimerElapsed);
    }

    private void onTimerElapsed(object sender, ElapsedEventArgs e)
    {
        //stuff that happens when timer has elapsed, aka time that power-up is in effect ends
        deactivate();
    }

    public void deactivate()
    {
        _timer.Stop();
        _isActive = false;
        Debug.Log(this.GetType().Name + " depleted.");
        _eventManager.dispatchEvent(_go, EventArgs.Empty, powerUpDeactivationEvent);
    }




    public void pause()
    {
        _timer.Enabled = false;
        _isActive = false;
    }

    public void OnApplicationQuit()
    {
        if (_isActive)
        {
            _timer.Stop();
        }
        
    }


}