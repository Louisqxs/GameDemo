using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_ExpTable : MonoBehaviour
    {
        public Flowchart flowchart;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("ExpTableClickTime", 0);
            PlayerPrefs.Save();
        }

        void OnEnable()
        {
            EventManager.StartListening("LETTERCLICKED", ClickTimeAdd);
        }

        void OnDisable()
        {
            EventManager.StopListening("LETTERCLICKED", ClickTimeAdd);
        }

        public void ClickTimeAdd()
        {
            PlayerPrefs.SetInt("ExpTableClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickExpTable()
        {
            int ClickTime = PlayerPrefs.GetInt("ExpTableClickTime");
            if (ClickTime == 0)
            {
                flowchart.ExecuteBlock("ExpTable");
            }
            else if (ClickTime == 1)
            {
                EventManager.TriggerEvent("ExpTableShow");
            }
        }
    }
}
