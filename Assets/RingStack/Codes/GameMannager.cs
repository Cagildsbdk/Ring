using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMannager : MonoBehaviour
{
   public GameObject [] red = new GameObject [2] ;
   public GameObject [] green = new GameObject [1] ;  
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (red[0].GetComponent<ForRed>().check && red[1].GetComponent<ForRed>().check && red[2].GetComponent<ForRed>().check && green[1].GetComponent<ForRed>().check && green[0].GetComponent<ForRed>().check )
        {
            Debug.Log("Well Done");
        }
        else
            Debug.Log("Try Again");
    }
}
