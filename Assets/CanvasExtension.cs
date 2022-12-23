using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CanvasExtension : MonoBehaviour
{
    private RectTransform rT;
    private void Start()
    {
        rT = gameObject.GetComponent<RectTransform>();
        SliderExtension.startHolding += SetPos;
    }

    public void SetPos(Vector2 clickPosision)
    {
        rT.position = clickPosision;
    }
}
