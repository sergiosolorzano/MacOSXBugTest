using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;


public class PressedScript : MonoBehaviour
{
    public Text thisText;

   public void PushedButton1()
    {
        thisText.text = "PressedA";
    }
    public void PushedButton2()
    {
        thisText.text = "PressedB";
    }
}
