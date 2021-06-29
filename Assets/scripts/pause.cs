using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pause : MonoBehaviour
{
    public Image blackScreen;
    public GameObject PauseMenu;
    public void Toggle() { 
    
        bool pause = !blackScreen.enabled;
        blackScreen.enabled = pause;
        PauseMenu.SetActive(pause);
        Time.timeScale = pause ? 0 : 1;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Toggle();
        }
    }
}
