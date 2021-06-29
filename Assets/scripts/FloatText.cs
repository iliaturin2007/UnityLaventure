using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FloatText : MonoBehaviour, IFloat
{
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void IFloat.Use(float f)
    {
        text.text = ((int)f).ToString();
    }
}
