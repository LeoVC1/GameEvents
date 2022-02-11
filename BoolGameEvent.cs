using System.Collections.Generic;
using UnityEngine;

namespace Plugins.GameEvents
{
    [CreateAssetMenu(fileName = "BoolGameEvent", menuName = "Scriptable Objects/Events/Bool Game Event")]
    public class BoolGameEvent : ScriptableObject
    {
        private List<BoolGameEventListener> listeners = new List<BoolGameEventListener>();

        public void Raise(bool value)
        {
            for(int i = listeners.Count - 1; i >= 0; i--)
            {
                listeners[i].OnEventRaised(value);
            }
        }

        public void RegisterListener(BoolGameEventListener listener)
        {
            if (!listeners.Contains(listener))
            {
                listeners.Add(listener);
            }
        }

        public void UnregisterListener(BoolGameEventListener listener)
        {
            if (listeners.Contains(listener))
            {
                listeners.Remove(listener);
            }
        }

    }
}
