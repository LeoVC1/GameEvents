using System.Collections;
using System.Collections.Generic;
using Plugins.GameEvents;
using UnityEngine;

[CreateAssetMenu(fileName = "SimpleGameEvent", menuName = "Scriptable Objects/Events/Simple Game Event")]
public class SimpleGameEvent : ScriptableObject
{
    private List<SimpleGameEventListener> listeners = new List<SimpleGameEventListener>();

    public void Raise()
    {
        for(int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(SimpleGameEventListener listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }

    public void UnregisterListener(SimpleGameEventListener listener)
    {
        if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }

}
