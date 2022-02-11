using System.Collections.Generic;
using UnityEngine;

namespace Plugins.GameEvents
{
    [CreateAssetMenu(fileName = "IntGameEvent", menuName = "Scriptable Objects/Events/Int Game Event")]
    public class IntGameEvent : ScriptableObject
    {
        private List<IntGameEventListener> listeners = new List<IntGameEventListener>();

        public void Raise(int value)
        {
            for(int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(value);
            }
        }

        public void RegisterListener(IntGameEventListener listener)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
            }
        }

        public void UnregisterListener(IntGameEventListener listener)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            }
        }

    }
}
