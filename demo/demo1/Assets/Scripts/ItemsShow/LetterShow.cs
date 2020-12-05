using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LetterShow : MonoBehaviour
{
    //GameObject gameobject;

    void OnEnable()
    {
        EventManager.StartListening("LETTERHIDE", Hide);
        EventManager.StartListening("LETTERSHOW", Show);
    }

    void OnDisable()
    {
        EventManager.StopListening("LETTERHIDE", Hide);
        EventManager.StopListening("LETTERSHOW", Show);
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
