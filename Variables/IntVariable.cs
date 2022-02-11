using UnityEngine;

namespace Plugins.GameEvents.Variables
{
    [CreateAssetMenu(fileName = "IntVariable", menuName = "Scriptable Objects/Variables/Int")]
    public class IntVariable : ScriptableObject
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                this._value = value;
                onValueChangeEvent.Raise(value);
            }
        }
        public IntGameEvent onValueChangeEvent;
    }
}
