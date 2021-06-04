using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{


    [SerializeField] private GameObject box2;
    [SerializeField] private float speed;
    [SerializeField] private Transform spawnPosition;





    private void Start()
    {
        



    }

    void Update()
    {

        box2.transform.Translate(new Vector3(1f, 0f, 0f) * speed * Time.deltaTime);

        if (transform.position.y <= -3) 
        {


            print("Земля");
        }

        if (transform.position.y <= -10) 
        {

            transform.position = Vector3.zero;
      }
    
        if(box2.transform.position.x <= -16)
        {
           box2.transform.position = spawnPosition.position;


        }
   
    
    }
}
