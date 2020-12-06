using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Fungus
{
    public class Click_Letter : MonoBehaviour
    {

        [RuntimeInitializeOnLoadMethod]
        public static void Init()
        {
            PlayerPrefs.SetInt("LetterClickTime", 0);
            PlayerPrefs.Save();
        }

        void OnEnable()
        {
            EventManager.StartListening("MACHINECLICKED_1", ClickTimeAdd);
        }

        void OnDisable()
        {
            EventManager.StopListening("MACHINECLICKED_1", ClickTimeAdd);
        }

        public void ClickTimeAdd()
        {
            PlayerPrefs.SetInt("LetterClickTime", 1);
            PlayerPrefs.Save();
        }

        public void ClickLetter()
        {
            int ClickTime = PlayerPrefs.GetInt("LetterClickTime");
            if (ClickTime == 0)
            {

            }
            else if (ClickTime == 1)
            {
                EventManager.TriggerEvent("LETTERCLICKED");
                EventManager.TriggerEvent("LETTERSHOW");
                PlayerPrefs.SetInt("WardrobeClosedClickTime", 1);
                PlayerPrefs.SetInt("DeskClickTime", 1);
                PlayerPrefs.Save();
            }
        }
    }
}
