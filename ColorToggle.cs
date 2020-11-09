using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorToggle : MonoBehaviour
{
    public void ToggleColor()
    {
        Image img = gameObject.GetComponent<Image>();
        if (img.color == Color.red)
        {
            img.color = Color.white;
        } else
        {
            img.color = Color.red;
        }
    }
}
