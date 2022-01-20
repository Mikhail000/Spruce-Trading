using UnityEngine;

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

        private void OnEnable() => ClickReceiver.Click += DebugClickValue;
        private void OnDisable() => ClickReceiver.Click -= DebugClickValue;

        private void DebugClickValue()
        {
            Debug.Log(OneClickValue);
        }
    }
}
