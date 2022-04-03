using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMannager : MonoBehaviour
{
   public GameObject [] Boxes;
    string[] Tags = new string[3];
    public bool check;
    void Start()
    {
        check = false;
        Tags[0] = Boxes[0].GetComponent<BoxFeedbacker>().TagCOntrol(); ;
        Debug.Log(Tags[0]);
        Tags[1] = Boxes[1].GetComponent<BoxFeedbacker>().TagCOntrol(); ;
        Tags[2] = Boxes[2].GetComponent<BoxFeedbacker>().TagCOntrol(); ;
       
    }

   


    void Update()
    {
        if (Tags[0] == Tags[1] && Tags[1] == Tags[2])
        {
            check = true;
        }
        else if (Tags[0] == Tags[1] && Tags[2] == "")
        {
            check = true;
        }
        else if (Tags[0] == "Red" || Tags[0] == "Green" && Tags[1] == "" && Tags[2] == "")
        {
            check = true;
        }
        else if (Tags[0] == "" && Tags[1] == "" && Tags[2] == "")
        {
            check = true;
        }
        else
            check = false;


    }


    //Burada En ustdeki kutu baska bir oge tarafindan triggerlandiginda assagisindaki kutucuklarin dolu olup olmadigini kotrol eder ve buna gore simiti yerlestirir ya da yerlestirmez.
    void OnTriggerEnter(Collider other)
    {
      
            if (Boxes[0].GetComponent<BoxFeedbacker>().Kontrol())
            {
                other.gameObject.transform.position = Boxes[0].transform.position;
                Tags[0] = Boxes[0].GetComponent<BoxFeedbacker>().TagCOntrol();
                Debug.Log(Tags[0]);

            }
            else if (Boxes[1].GetComponent<BoxFeedbacker>().Kontrol())
            {
                other.gameObject.transform.position = Boxes[1].transform.position;
                Tags[1] = Boxes[1].GetComponent<BoxFeedbacker>().TagCOntrol();
            }
            else if (Boxes[2].GetComponent<BoxFeedbacker>().Kontrol())
            {
                other.gameObject.transform.position = Boxes[2].transform.position;
                Tags[2] = Boxes[2].GetComponent<BoxFeedbacker>().TagCOntrol();
            }
        

    }
    public bool FinalCheck() 
    {
       //  Debug.Log(check);
        //check = true;
        return check;
    }
}
