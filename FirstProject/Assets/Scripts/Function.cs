using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
   



    private void Start()
    {
        print("������ " + WhichNumGreater(5f, 10f) + "� �����");
        print("������ " + WhichNumGreater(25f, 10f) + "� �����");
        print("������ " + WhichNumGreater(0.0000005f, 0.00000002f) + "� �����");
    }

    
  
   
   private string WhichNumGreater(float a, float b)
    {
        if(a > b)
          
        {
            print("����� ������ �� " + (a - b));
            
            return "1";
    
        }
        else if(a == b)
        {
            print("����� �����");
            return "0";
        }
        else
        {
         
            return "2";
        }
    
    
    }



}//

