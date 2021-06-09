using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    [SerializeField] private int[] myArray; //обьявили массив.

    [SerializeField] private int[] myArray1 =  new int[3] ; //обьявили массив и задали размер
    [SerializeField] private int[] myArray2 = new int[3] { 1, 2, 3, };
                                               //Index    0  1  2  3  4  5  6
    [SerializeField] private int[] myArray3 = new int[] { 1, 2, 3, 4, 5, 6, 7 };




    void Start()
    {
        print(myArray[0]);
        myArray[0] = 1000;
        print(myArray[0]);
    }


    
    void Update()
    {
        

    }
}
