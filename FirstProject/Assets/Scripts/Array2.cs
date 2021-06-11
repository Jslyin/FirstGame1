using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array2 : MonoBehaviour
{
    [SerializeField] private string[] myFilms = new string[] { "’од€чие", "Batman", "’алк","ќбливион" };
    void Start()
    {

        PrintArray();
        myFilms[0] = "Taxi";
        PrintArray();

        foreach (string item in myFilms)
        {
             if(item != "Batman" )
            print(item);


        }

    }

    
    void PrintArray()
    {
        string j = "";

        print(myFilms.Length - 1);

        for (int i = 0; i < myFilms.Length; i++)
        {

            j = j + myFilms[i] + ", " ;
            if (i == myFilms.Length - 1)  
            {
                j = j + myFilms[i] + ", ";
               j = j + myFilms[i] + ". ";
            }
            
               
            

        }
        print(j);
    }
}
