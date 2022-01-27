
// class -ClickReceiver- contains events for managing clicks.

using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Clicker
{
    public class ClickReceiver : MonoBehaviour, IPointerClickHandler
    {
        float clickValue;
        public static event UnityAction<float> Click;

        public void OnPointerClick(PointerEventData eventData)
        {
            Click?.Invoke(clickValue);
        
            Debug.Log("Здарова, заебал");
        }
    }
}
