using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public void destroyGameObject(GameObject obj)
    {
        Destroy(obj);
    }
    public void Destroy()
    {
        Destroy(gameObject);
    }
}
