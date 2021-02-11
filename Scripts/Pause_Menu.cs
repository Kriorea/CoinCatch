using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_Menu : MonoBehaviour
{

   
    public void PauseMenu()
    {
        if (Time.timeScale != 0) Time.timeScale = 0; else Time.timeScale =1;
    }
}
