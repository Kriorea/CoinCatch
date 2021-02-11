using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    
public bool player;
    
    
     void Update()
    {
     CheckDeath();
    }
    void CheckDeath() 
    {
        if (transform.position.y <-7)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GamePlay");
        } 
    }
}
