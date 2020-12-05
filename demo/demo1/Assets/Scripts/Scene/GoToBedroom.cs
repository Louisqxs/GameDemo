using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToBedroom : MonoBehaviour
{
    public void Click()
    {
        SceneManager.LoadScene("Bedroom_Lead");
    }
}
