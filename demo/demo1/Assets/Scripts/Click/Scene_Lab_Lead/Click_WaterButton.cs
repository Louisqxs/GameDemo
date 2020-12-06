using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_WaterButton : MonoBehaviour
    {
        public Flowchart flowchart;

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("WaterButtonClickTime", 0);
            PlayerPrefs.Save();
        }

        void OnEnable()
        {
            EventManager.StartListening("HAVEWATER", ClickTimeAdd1);
            EventManager.StartListening("WATERCORRECT", ClickTimeAdd2);
        }

        void OnDisable()
        {
            EventManager.StopListening("HAVEWATER", ClickTimeAdd1);
            EventManager.StopListening("WATERCORRECT", ClickTimeAdd2);
        }

        public void ClickTimeAdd1()
        {
            PlayerPrefs.SetInt("WaterButtonClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickTimeAdd2()
        {
            PlayerPrefs.SetInt("WaterButtonClickTime", 2);
            PlayerPrefs.Save();
        }

        public void ClickWaterButton()
        {
            int ClickTime = PlayerPrefs.GetInt("WaterButtonClickTime");
            if (ClickTime == 0)
            {
                flowchart.ExecuteBlock("Water_Null");
            }
            else if (ClickTime == 1 )
            {
                flowchart.ExecuteBlock("Water_Wrong");
            }
            else if (ClickTime == 2)
            {
                flowchart.ExecuteBlock("Water_Correct");
            }

        }
    }
}
