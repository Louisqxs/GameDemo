using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLab : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Lab_Lead");
    }
}
