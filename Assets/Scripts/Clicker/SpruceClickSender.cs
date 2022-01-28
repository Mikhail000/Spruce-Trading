
// class -ClickReceiver- contains events for managing clicks.

using UnityEngine;
using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Clicker
{
    public class SpruceClickSender : MonoBehaviour, IPointerClickHandler
    {
        public delegate void Click(float argument);
        public static event Click spruceClick;

        public void OnPointerClick(PointerEventData eventData)
        {

            spruceClick?.Invoke(0f);

            Debug.Log(name + "Здарова, заебал");
        }
    }
}
