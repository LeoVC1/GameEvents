using UnityEngine;
using UnityEngine.Events;

namespace Plugins.GameEvents
{
    public class SimpleGameEventListener : MonoBehaviour
    {
        public SimpleGameEvent Event;
        public UnityEvent Response;

        private void OnEnable()
        {
            Event.RegisterListener(this);
        }

        private void OnDisable()
        {
            Event.UnregisterListener(this);
        }

        public void OnEventRaised()
        {
            Response.Invoke();
        }
    }
}
