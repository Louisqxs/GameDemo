using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_Bookcase : MonoBehaviour
    {
        public Flowchart flowchart;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("BookcaseClickTime", 0);
            PlayerPrefs.Save();
        }

        void OnEnable()
        {
            GetComponent<CanvasGroup>().alpha = 1;
            transform.localScale = Vector3.one;
            //EventManager.StartListening("LETTERCLICKED", ClickTimeAdd);
        }

        void OnDisable()
        {
            //EventManager.StopListening("LETTERCLICKED", ClickTimeAdd);
        }

        public void ClickTimeAdd()
        {
            PlayerPrefs.SetInt("BookcaseClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickBookcase()
        {
            int ClickTime = PlayerPrefs.GetInt("BookcaseClickTime");
            if (ClickTime == 0)
            {
                flowchart.ExecuteBlock("Bookcase");
            }
            else if (ClickTime == 1)
            {
                GetComponent<CanvasGroup>().alpha = 0;
                transform.localScale = Vector3.zero;
                EventManager.TriggerEvent("BOOKCASESHOW");
            }
        }
    }
}
