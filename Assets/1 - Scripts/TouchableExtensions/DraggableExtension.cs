using UnityEngine;
using UnityEngine.EventSystems;

public class DraggableExtension : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public RectTransform rectTransform;

    public virtual void Awake()
    {
        
    }

    public virtual void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("OnBeginDrag");
    }

    public virtual void OnDrag(PointerEventData eventData)
    {
        Debug.Log("OnDrag");
    }

    public virtual void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("OnEndDrag");
    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("OnPointerDown");
    }
}
