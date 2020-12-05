using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_Computer : MonoBehaviour
    {
        public Flowchart flowchart;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("ComputerClickTime", 0);
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
            PlayerPrefs.SetInt("ComputerClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickComputer()
        {
            int ClickTime = PlayerPrefs.GetInt("ComputerClickTime");
            if (ClickTime == 0)
            {
                flowchart.ExecuteBlock("Computer");
            }
            else if (ClickTime == 1)
            {
                EventManager.TriggerEvent("ComputerShow");
            }
        }
    }
}