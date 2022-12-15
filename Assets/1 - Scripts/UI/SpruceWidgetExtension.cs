using UnityEngine;
using Spruce;

public class SpruceWidgetExtension : MonoBehaviour
{
    [SerializeField]public SpruceSpeciesIDs Id;
        
    [SerializeField] private string spruceName;
    public delegate void ButtonClick(string name);
    public static event ButtonClick buttonClick;

    private void OnEnable()
    {
        
    }

    public void PassSpruceNameToSpawn()
    {
        buttonClick?.Invoke(spruceName);
    }

    /*
    public Image spruceWidgetImage;
    public GameObject sprucePrefab;
    public Transform parentWidgetPosition;

    public override void Awake()
    {
        base.Awake();
        parentWidgetPosition = transform.parent.transform;
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        spruceWidgetImage.enabled = false;
        sprucePrefab.SetActive(true);
        
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        rectTransform.anchoredPosition += eventData.delta;
    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        transform.position = parentWidgetPosition.position;
        spruceWidgetImage.enabled = true;
        sprucePrefab.SetActive(false);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        base.OnPointerDown(eventData);
        
    }
    */
}
