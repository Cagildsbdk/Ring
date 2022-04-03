using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public GameObject[] Simit;
    private Touch touch;
    private float speedModifier;
    int i;
   

     //Burada ogelerin ekran ustundeki kontrolu saglanir.
        

    void Start()
    {
        speedModifier = 0.0001f;
        i = 0;
    }
    public void ButtonPress()
    {
        if(i >= 3)
        {
            i = 0;
        }
        i++;
        
    }
   
    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                Simit[i].transform.position = new Vector3(Simit[i].transform.position.x, Simit[i].transform.position.y + (touch.deltaPosition.y / 1.2f) * speedModifier, Simit[i].transform.position.z + (-1 * touch.deltaPosition.x / 1.2f) * speedModifier);
            }
        }
    }


}
