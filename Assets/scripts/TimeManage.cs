using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManage : MonoBehaviour
{
    // Start is called before the first frame update
    public void TimeManager(float time)
    {
        Time.timeScale = time;
    }
}
