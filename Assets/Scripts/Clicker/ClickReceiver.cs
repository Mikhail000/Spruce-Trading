using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace Clicker
{
    public class ClickReceiver : MonoBehaviour, IPointerClickHandler
    {
        public static event UnityAction Click;
        public void OnPointerClick(PointerEventData eventData)
        {
            Click?.Invoke();
            Debug.Log("Здарова, заебал");
        }
    }
}
