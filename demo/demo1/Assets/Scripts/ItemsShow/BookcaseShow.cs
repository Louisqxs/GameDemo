using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookcaseShow : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.StartListening("BOOKCASESHOW", Show);
    }

    void OnDisable()
    {
        EventManager.StopListening("BOOKCASESHOW", Show);
    }

    // Use this for initialization
    void Start()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        transform.localScale = Vector3.zero;
    }
    public void Hide()
    {
        GetComponent<CanvasGroup>().alpha = 0;
        transform.localScale = Vector3.zero;
    }

    public void Show()
    {
        GetComponent<CanvasGroup>().alpha = 1;
        transform.localScale = Vector3.one;
    }
}

