using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_Desk : MonoBehaviour
    {
        public Flowchart flowchart;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("DeskClickTime", 0);
            PlayerPrefs.Save();
        }

        //void OnEnable()
        //{
        //    EventManager.StartListening("LETTERCLICKED", ClickTimeAdd);
        //}

        //void OnDisable()
        //{
        //    EventManager.StopListening("LETTERCLICKED", ClickTimeAdd);
        //}

        //public void ClickTimeAdd()
        //{
        //    PlayerPrefs.SetInt("DeskClickTime", 1);
        //    PlayerPrefs.Save();
        //}

        public void ClickDesk()
        {
            int ClickTime = PlayerPrefs.GetInt("DeskClickTime");
            if (ClickTime == 0)
            {
                flowchart.ExecuteBlock("Desk");
            }
            else if (ClickTime == 1)
            {
                EventManager.TriggerEvent("DESKPAPERSHOW");
            }
        }
    }
}

