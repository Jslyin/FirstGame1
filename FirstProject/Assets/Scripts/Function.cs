using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Function : MonoBehaviour
{
   



    private void Start()
    {
        print("больше " + WhichNumGreater(5f, 10f) + "е число");
        print("больше " + WhichNumGreater(25f, 10f) + "е число");
        print("больше " + WhichNumGreater(0.0000005f, 0.00000002f) + "е число");
    }

    
  
   
   private string WhichNumGreater(float a, float b)
    {
        if(a > b)
          
        {
            print("Число больше на " + (a - b));
            
            return "1";
    
        }
        else if(a == b)
        {
            print("Числа равны");
            return "0";
        }
        else
        {
         
            return "2";
        }
    
    
    }



}//

