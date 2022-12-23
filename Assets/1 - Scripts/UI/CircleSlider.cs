using System;
using System.Collections;
using System.Timers;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class CircleSlider : MonoBehaviour 
{
    [SerializeField] private Image image;
    [SerializeField] private RectTransform parent;
    [SerializeField] private Camera camera;
    [SerializeField] private RectTransform imageRect;

    private bool isHolded;

    public delegate void SliderOnFilled();
    
    public static event SliderOnFilled sliderOnFilled;
    
    private void Start()
    {
        isHolded = false;
        image = gameObject.GetComponent<Image>();
        imageRect = gameObject.GetComponent<RectTransform>();
        camera = GameObject.Find("Camera").GetComponent<Camera>();
        parent = GameObject.Find("UI").GetComponent<RectTransform>();

        SliderExtension.startHolding += StartFilling;
        SliderExtension.onRelease += StopFilling;
    }

    private void Update()
    {

        var currentFillAmount = image.fillAmount;
        if (isHolded)
        {
            image.fillAmount += 2f * Time.deltaTime; 
        }
        if (currentFillAmount == 1)
        {
            ResetSlider();
        }
    }

    public void StartFilling(Vector2 clickPosision)
    {
        Vector2 anchoredPos;

        RectTransformUtility.ScreenPointToLocalPointInRectangle(parent, clickPosision, camera, out anchoredPos);

        imageRect.anchoredPosition = anchoredPos;

        isHolded = true;
    }

    public void StopFilling()
    {
        isHolded = false;
        ResetSlider();
    }

    public void ResetSlider()
    {
        image.fillAmount = 0f;
        isHolded = false;
    }
}
