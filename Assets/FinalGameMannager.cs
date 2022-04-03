using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGameMannager : MonoBehaviour
{
    public GameObject [] Boxes;   
 
    void Start()
    {
        
    }




    //Eger butun simitler dogru siralandiysa oyun biter.

    void LateUpdate()
    {
        if (Boxes[0].GetComponent<GameMannager>().FinalCheck() == true && Boxes[1].GetComponent<GameMannager>().FinalCheck() == true && Boxes[2].GetComponent<GameMannager>().FinalCheck() == true) 
        {
            Debug.Log("WIIIIIIN");
        
        }
    }
}
