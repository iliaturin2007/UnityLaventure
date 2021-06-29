using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceDrain : MonoBehaviour
{
    private resource drain;
    public float speed;
    public string resName = "Water";
    // Start is called before the first frame update
    void Start()
    {
        drain = resource.Find(resName);
    }

    // Update is called once per frame
    void Update()
    {
        drain.Change(-speed * Time.deltaTime);
    }
}
