// Класс  содержит данные о "клике".
// Сколько стоит клик, насколько бонусы увеличивают клик и тд.

using Unity.VisualScripting;
using UnityEngine;

namespace Scripts
{
    public class ClickData : MonoBehaviour
    {
        [SerializeField] private float _oneClickValue;

        private float _clickValue;
        
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
