using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForRed : MonoBehaviour
{
    [SerializeField]
    public bool check;
    void Start()
    {
        check = true;
    }

    private void OnTriggerEnter(Collider other)
    {

         if (other.tag == "Red")
        {
            check = true;
        }
    }
}
