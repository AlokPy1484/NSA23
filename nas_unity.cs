using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextScript : MonoBehaviour
{
    public Text text;

    public void Start()
    {
        int a = 10;
        int b = 4;

        var c = "100";

        text.text = c ;
        //myText.GetComponent<Text›().text = "second one";



     
    }

    public void NextTextUpdate()
    {
        Start();
    }

    public void BackTextUpdate()
    {

    }

}