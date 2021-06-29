using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adder : MonoBehaviour
{
    public float speed;
    public string strName;
    public bool DestroyObj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            resource.Find(strName).Change(speed);
            if (DestroyObj)
                Destroy(gameObject);
        }
    }
}
