// класс ClickExtension - компонент для считывания клика. Содержит события для управления логикой в последствие клика.

using System;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using System.Diagnostics;
using Debug = UnityEngine.Debug;

namespace Scripts
{
    public class ClickExtension : MonoBehaviour, IExtension, IPointerDownHandler, IPointerUpHandler
    {
        public delegate void Click();
        public static event Click click;
        
        private float _clickDuration;
        private bool _isClickHeld;

        private void Start()
        {
            _clickDuration = 0.2f;
        }

        public void EnableExtension()
        {
            enabled = true;
        }

        public void DisableExtension()
        {
            enabled = false;
        }
        
        public void OnPointerDown(PointerEventData eventData)
        {
            _isClickHeld = true;

            StartCoroutine(OnHold());
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _isClickHeld = false;
        }

        private IEnumerator OnHold()
        {
            while (_isClickHeld)
            {
                click?.Invoke();
                yield return new WaitForSeconds(_clickDuration);
            }
        }
        
    }
}
