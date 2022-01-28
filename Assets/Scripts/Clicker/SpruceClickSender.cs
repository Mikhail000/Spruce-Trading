
// class -ClickReceiver- contains events for managing clicks.

using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Clicker
{
    public class SpruceClickSender : MonoBehaviour, IPointerClickHandler, IPointerDownHandler
    {
        private IPointerDownHandler _pointerDownHandlerImplementation;

        public delegate void Click(float argument);
        public static event Click spruceClick;


        public void OnPointerClick(PointerEventData eventData)
        {
            spruceClick?.Invoke(0f);

            Debug.Log(name + " Здарова, заебал");
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _pointerDownHandlerImplementation.OnPointerDown(eventData);
        }
    }
}
