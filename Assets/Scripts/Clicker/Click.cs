// class -Click- contains states and behaviors for an "click" entity

using UnityEngine;
using Clicker;

namespace Clicker
{
    public class Click : MonoBehaviour
    {
        private float _oneClickValue;
        public float OneClickValue
        {
            get
            {
                return _oneClickValue;
            }
            private set
            {
                _oneClickValue = value;
            }
        }

        private void Start()
        {
            _oneClickValue = 1f;
        }

        public void IncreaseClickValue(float amount)
        {
            OneClickValue += amount;
        }

        public void ReduceClickValue(float amount)
        {
            OneClickValue -= amount;
        }

        private void OnEnable() => SpruceClickSender.spruceClick += DebugClickValue;
        private void OnDisable() => SpruceClickSender.spruceClick -= DebugClickValue;

        private void DebugClickValue(float clickValue)
        {
            Debug.Log(OneClickValue);
        }
    }
}
