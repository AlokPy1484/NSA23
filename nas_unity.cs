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

        int ran = 0;
        StreamReader reader = new StreamReader("/Users/alokpandey/Desktop/aaa/nasa_data_f.csv");
        data = reader.ReadLine();
        // Console.WriteLine(data);
        List<string> listA = new List<string>();



        //to select a random planet from our data set-----------------
        for(int i = 0; i < ran;i++){
            data = reader.ReadLine();}
            // Console.WriteLine(data);}

        var values = data.Split(','); 

        //to add each parameter in list one by one-----------------
        foreach (var item in values)
        {   listA.Add(item);

        }


        // while (data != null){
        //     foreach (var item in values){
        //     listA.Add(item);}
        // }


        // Console.WriteLine(listA.Count);


        //to make a variable for each parameter of planet-----------------------------
        string name = listA[0];
        string sun_n = listA[1];
        string year = listA[2];
        string orb_p = listA[3];
        string radi = listA[4];
        string mass = listA[5];
        string temp = listA[6];


        text.text = name ;

        foreach (var dat in listA){
        Console.WriteLine(dat);}

        reader.Close();

        
    }

    public void NextTextUpdate()
    {
        Start();
    }

    public void BackTextUpdate()
    {

    }

}