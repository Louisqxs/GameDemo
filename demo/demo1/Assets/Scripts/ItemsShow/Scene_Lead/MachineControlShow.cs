using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineControlShow : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.StartListening("MACHINECONTROLSHOW", Show);
    }

    void OnDisable()
    {
        EventManager.StopListening("MACHINECONTROLSHOW", Show);
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
