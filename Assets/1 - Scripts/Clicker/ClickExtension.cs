// класс ClickExtension - компонент для считывания клика. Содержит события для управления логикой в последствие клика.

using UnityEngine;
using System;
using UnityEngine.EventSystems;
using System.Collections;

namespace Scripts
{
    public class ClickExtension : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {

        public delegate void Click();
        public static event Click click;

        private Vector3 _clickPosition;

        private float _clickDuration = 0.2f;

        private bool isClickHeld;
        
        public void OnPointerDown(PointerEventData eventData)
        {
            isClickHeld = true;

            StartCoroutine(OnHold());
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            isClickHeld = false;
            _clickPosition = eventData.position;

            Debug.Log("OBJECT WITH NAME - "
                      + name
                      + " CLICKED "
                      + " IN LOCAL OBJECTS POSITION - "
                      + _clickPosition);
        }

        #region PRIVATE

        private IEnumerator OnHold()
        {
            while (isClickHeld)
            {
                click?.Invoke();
                yield return new WaitForSeconds(_clickDuration);
            }
        }


        #endregion
    }
}
