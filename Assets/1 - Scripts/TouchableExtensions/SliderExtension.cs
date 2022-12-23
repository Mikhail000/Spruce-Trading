using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using Debug = UnityEngine.Debug;

public class SliderExtension : MonoBehaviour, IExtension, IPointerDownHandler, IPointerUpHandler
{
    
    #region Fields

    [SerializeField] private UIIDs requiredSliderName;

    [SerializeField] private GameObject requiredSliderType;

    [SerializeField] private GameObject currentSlider;

    [SerializeField] private Image currentSliderImage;

    [SerializeField] private CircleSlider curCircleSliderScript;

    [SerializeField] private float holdDuration;

    [SerializeField] private RectTransform rectTransofrm;

    private Vector2 clickPosision;

    private GameObject _canvas;

    private List<UIStorageNode> _sliders = new List<UIStorageNode>();

    private bool _isHolded;
    
    private GameObject _manager;

    #endregion

    #region Delegates

    public delegate void OnHold(Vector2 clickPosision);
    public static event OnHold startHolding;

    public delegate void OnRelease();
    public static event OnRelease onRelease;

    #endregion

    private void Start()
    {
        holdDuration = 2000;
        _manager = GameObject.Find("GameLogicHub");
        _sliders = _manager.GetComponent<GlobalUIsData>().uiStorage.Nodes;
        _canvas = _manager.GetComponent<GlobalUIsData>().mainCanvas;

        InitializeRequiredSlider();
    }

    public void EnableExtension()
    {
        this.enabled = true;
    }

    public void DisableExtension()
    {
        this.enabled = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        clickPosision = eventData.position;
        
        HoldDown();
        OnStartHolding();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        onRelease?.Invoke();
        HoldUp();
    }

    private void OnStartHolding()
    {
        startHolding?.Invoke(clickPosision);
    }

    private void HoldDown()
    {
        _isHolded = true;
    }

    private void HoldUp()
    {
        _isHolded = false;
    }

    private void InitializeRequiredSlider()
    {
        var name = requiredSliderName.ToString();
        
        foreach (var node in _sliders)
        {
            UIStorageNode curNode = node;

            if (name == curNode.Id.ToString())
            {
                requiredSliderType = curNode.Prefab;
                currentSlider = Instantiate(requiredSliderType, _canvas.transform);
                currentSliderImage = currentSlider.GetComponent<Image>();
                rectTransofrm = currentSlider.GetComponent<RectTransform>();
                curCircleSliderScript = currentSlider.GetComponent<CircleSlider>();
            }
        }
    }
}
