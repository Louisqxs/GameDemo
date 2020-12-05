using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_Wardrobe_Opened : MonoBehaviour
    {
        public Flowchart flowchart;

        void OnEnable()
        {
            GetComponent<CanvasGroup>().alpha = 0;
            transform.localScale = Vector3.zero;
            EventManager.StartListening("OPENWARDROBE", ShowWardrobeOpened);
        }

        void OnDisable()
        {
            EventManager.StopListening("OPENWARDROBE", ShowWardrobeOpened);
        }

        public void ShowWardrobeOpened()
        {
            GetComponent<CanvasGroup>().alpha = 1;
            transform.localScale = Vector3.one;
        }

        public void HideWardrobeOpened()
        {
            GetComponent<CanvasGroup>().alpha = 0;
            transform.localScale = Vector3.zero;
            EventManager.TriggerEvent("CLOSEWARDROBE");
        }
    }
}