using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyList : MonoBehaviour
{
    [SerializeField] private List<string> cars; // �������� ������
    [SerializeField] private List<string> myCars = new List<string> {"�����", "�����", "������", "�����" }; 
    void Start()
    {
        print(myCars[2]);

       foreach(string car in myCars)
        {
            print(car);
        }
        myCars.Add("Ferarri");
        myCars.Remove("������");
        print("����� " + myCars.Count);
    }

    
    void Update()
    {
      
        
   
    }


}

