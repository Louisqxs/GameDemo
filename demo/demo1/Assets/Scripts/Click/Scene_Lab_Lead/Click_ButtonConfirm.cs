using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Fungus
{
    public class Click_ButtonConfirm : MonoBehaviour
    {
        public Flowchart flowchart;
        public InputField inputfield;
        private string password_correct = "82226517";

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("ButtonConfirmClickTime", 0);
            PlayerPrefs.Save();
        }

        void OnEnable()
        {
            EventManager.StartListening("WATERCORRECT", ClickTimeAdd);
        }

        void OnDisable()
        {
            EventManager.StopListening("WATERCORRECT", ClickTimeAdd);
        }
        

        public void ClickTimeAdd()
        {
            PlayerPrefs.SetInt("ButtonConfirmClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickButtonConfirm()
        {
            int ClickTime = PlayerPrefs.GetInt("ButtonConfirmClickTime");
            string password = inputfield.text;
            Debug.Log(password);
            if (password != password_correct)
            {
                flowchart.ExecuteBlock("Password_Wrong");
            }
            else if (ClickTime == 0)
            {
                flowchart.ExecuteBlock("Water_Wrong");
            }
            else if (password == password_correct && ClickTime == 1)
            {
                flowchart.ExecuteBlock("Password_Correct");
                EventManager.TriggerEvent("TRANSANIMATION");
            }

        }
    }
}