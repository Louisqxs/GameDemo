using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class PhotoShow : MonoBehaviour
{
    //GameObject gameobject;

    void OnEnable()
    {
        EventManager.StartListening("PHOTOSHOW", Show);
    }

    void OnDisable()
    {
        EventManager.StopListening("PHOTOSHOW", Show);
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
