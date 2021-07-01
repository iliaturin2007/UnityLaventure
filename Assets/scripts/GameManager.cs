using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void Load(string scene)
    {
        SceneManager.LoadScene(scene);
    }
    public void Reload()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void NextLevel()
    {
        string str = SceneManager.GetActiveScene().name;
        string Num = (int.Parse(str.ToCharArray()[str.Length - 1].ToString()) + 1).ToString();
        str = str.Remove(str.Length - 1);
        str += Num;
        Load(str);
    }
}
