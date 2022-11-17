// Класс Click содержит состояния и поведения для сущности "Клик".

using UnityEngine;
using System;

namespace Scripts
{
    public class Click : MonoBehaviour
    {
        [SerializeField] private float _oneClickValue;

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
            //_oneClickValue = 1f;
        }

        public void IncreaseClickValue(float amount)
        {
            OneClickValue += amount;
        }

        public void ReduceClickValue(float amount)
        {
            OneClickValue -= amount;
        }

        private void OnEnable() => ClickExtension.click += DebugClickValue;
        private void OnDisable() => ClickExtension.click -= DebugClickValue;

        private void DebugClickValue()
        {
            Debug.Log(OneClickValue);
        }

    }
}
