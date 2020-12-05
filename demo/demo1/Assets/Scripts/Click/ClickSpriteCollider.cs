using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class ClickSpriteCollider : MonoBehaviour
{
    private Image image;

    // Use this for initialization
    void Start()
    {
        image = this.GetComponent<Image>();
        image.alphaHitTestMinimumThreshold = 0.1f;
    }
}