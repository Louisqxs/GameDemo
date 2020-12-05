using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_Wardrobe_Closed : MonoBehaviour
    {
        public Flowchart flowchart;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("WardrobeClosedClickTime", 0);
            PlayerPrefs.Save();
        }

        void OnEnable()
        {
            EventManager.StartListening("CLOSEWARDROBE", ShowWardrobeClosed);
        }
        

        void OnDisable()
        {
            EventManager.StopListening("CLOSEWARDROBE", ShowWardrobeClosed);
        }

        public void ClickTimeAdd()
        {
            PlayerPrefs.SetInt("WardrobeClosedClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickWardrobeClosed()
        {
            int ClickTime = PlayerPrefs.GetInt("WardrobeClosedClickTime");
            if (ClickTime == 0)
            {
            }
            else if (ClickTime == 1)
            {
                GetComponent<CanvasGroup>().alpha = 0;
                transform.localScale = Vector3.zero;
                EventManager.TriggerEvent("OPENWARDROBE");
            }
        }

        public void ShowWardrobeClosed()
        {
            GetComponent<CanvasGroup>().alpha = 1;
            transform.localScale = Vector3.one;
        }
    }
}