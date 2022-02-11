using System.Collections;
using System.Collections.Generic;
using Plugins.GameEvents;
using UnityEngine;
using UnityEngine.Events;

public class BoolGameEventListener : MonoBehaviour
{
    public BoolGameEvent Event;
    public bool inverseParameter;
    public UnityEvent<bool> Response;

    private void OnEnable()
    {
        Event.RegisterListener(this);
    }

    private void OnDisable()
    {
        Event.UnregisterListener(this);
    }

    public void OnEventRaised(bool value)
    {
        if(inverseParameter)
            Response.Invoke(!value);
        else
            Response.Invoke(value);
    }
}
