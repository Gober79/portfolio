using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.InteropServices;

public class ButtonTest: MonoBehaviour
{
    public Text Davidisa;

    public void whatisdavid()
    {
        Davidisa.text = "A really nice guy";
    }
    public void buttonexit()
    {
        Application.Quit();
    }
}
