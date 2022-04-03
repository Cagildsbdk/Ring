using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxFeedbacker : MonoBehaviour
{
    //Burada simitlerin tagleri alinir ve kutucuklarin her hangi bir nesneye carpip carpmadigi buna gore de pozisyonunun bos ya da dolu oldugu belirtilir.

    [SerializeField]
    public bool check;
    string Tags;
    void Start()
    {
        Tags = "";
        check = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        check = false;
        Tags = other.tag;
        Debug.Log(Tags);

    }

    public void OnTriggerExit(Collider other)
    {
        check = true;
        Tags = "";
    }

    public bool Kontrol()
    {
        return check;
    }

    public string TagCOntrol() 
    {
        return Tags;
    }
}
