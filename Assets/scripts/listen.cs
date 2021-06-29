using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IFloat{
    void Use(float f);
}
public class listen : MonoBehaviour
{
    public string resourceName = "gold";
    private IFloat[] users;
    private void Start()
    {
        resource.Find(resourceName).action += UseValue;
        users = GetComponentsInChildren<IFloat>();
    }
    public void UseValue(float value)
    {
        foreach(var user in users)
        {
            user.Use(value);
        }
    }
}
