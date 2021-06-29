using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class foot : MonoBehaviour
{
    public PlayerControllers coll;
    private void Update()
    {
        //coll.FootCollision = true;
    }
    private void OnTriggerStay(Collider other)
    {
        try
        {
            if (other.gameObject.tag == "ground")
                coll.FootCollision = true;
        }
        finally { };
    }
    private void OnTriggerExit(Collider other)
    {
        try
        {
            if (other.gameObject.tag == "ground")
                coll.FootCollision = false;
        }
        finally { };
    }
}
