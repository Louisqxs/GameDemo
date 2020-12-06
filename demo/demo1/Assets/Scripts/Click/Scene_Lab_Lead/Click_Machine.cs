using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_Machine : MonoBehaviour
    {
        public Flowchart flowchart;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("MachineClickTime", 0);
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
            PlayerPrefs.SetInt("MachineClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickMachine()
        {
            int ClickTime = PlayerPrefs.GetInt("MachineClickTime");
            if (ClickTime == 0)
            {
                flowchart.ExecuteBlock("Machine_1");
                EventManager.TriggerEvent("MACHINECLICKED_1");
            }
            else if(ClickTime == 1)
            {
                EventManager.TriggerEvent("MACHINECONTROLSHOW");
                flowchart.ExecuteBlock("Machine_2");
            }
        }
    }
}
