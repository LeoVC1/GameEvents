using UnityEngine;
using UnityEngine.Events;

namespace Plugins.GameEvents
{
    public class IntGameEventListener : MonoBehaviour
    {
        public IntGameEvent Event;
        public UnityEvent<int> Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised(int value)
        {
            Response.Invoke(value);
        }
    }
}
