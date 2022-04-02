using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForGreen : MonoBehaviour
{
    [SerializeField]
    bool check;
    void Start()
    {
        check = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
      
         if (other.tag == "Green")
        {
            check=true; 
        }
    }
}
