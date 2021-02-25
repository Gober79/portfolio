using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InputBoxCode : MonoBehaviour
{
    public string Response;
    public InputField Guess;
    public Text Done;

    public void Answer()
    {
        Response = Guess.text;

        if (Response == "4")
        {
            Done.text = "Correct!!!";
        }
        else
        {
            Done.text = "Incorrect!!!";
        }
    }
}
