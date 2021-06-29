using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class resource : MonoBehaviour
{
    public static resource Find(string name)
    {
        foreach(var res in FindObjectsOfType<resource>())
        {
            if (res.res_name == name)
                return res;
        }
        return null;
    }
    [SerializeField] private string res_name;
    [SerializeField] private float res_count = 0;
    [SerializeField] private float res_maxCount = 99;
    public UnityEvent IfNullCount, IfMaxCount;
    public event Action<float> action;
    public float GetMaxValue()
    {
        return res_maxCount;
    }
    public void Activator()
    {
        res_count++;
        res_count = Mathf.Clamp(res_count, 0, res_maxCount);
        action?.Invoke(res_count);
        if (res_count == 0)
        {
            IfNullCount.Invoke();
        }
        if(res_count == res_maxCount)
        {
            IfMaxCount.Invoke();
        }
    }
    public void Change(float res)
    {
        res_count+=res;
        res_count = Mathf.Clamp(res_count, 0, res_maxCount);
        action?.Invoke(res_count);
        if (res_count == 0)
        {
            IfNullCount.Invoke();
        }
        if (res_count == res_maxCount)
        {
            IfMaxCount.Invoke();
        }
    }
}
