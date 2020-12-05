﻿using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickTrigger_2 : MonoBehaviour
{
    public GameObject gameobject;
    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 1;
        gameObject.transform.localScale = Vector3.one;
    }
    public void Hide()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
        gameObject.transform.localScale = Vector3.zero;
    }

    public void Show()
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 1;
        gameObject.transform.localScale = Vector3.one;
    }

}