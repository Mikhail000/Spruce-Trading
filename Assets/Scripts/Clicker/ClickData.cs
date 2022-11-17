// Класс  содержит данные о "клике".
// Сколько стоит клик, насколько бонусы увеличивают клик и тд.


using UnityEngine;
using System;

namespace Scripts
{
    public class ClickData : MonoBehaviour
    {
        [SerializeField] private float _oneClickValue;

        // Свойство хранящее числ. значение 'клика'
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

        // Подписуёмся на события клика
        private void OnEnable() => ClickExtension.click += DebugClickValue;
        private void OnDisable() => ClickExtension.click -= DebugClickValue;

        private void DebugClickValue()
        {
            Debug.Log(OneClickValue);
        }

    }
}
