using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public static int Score = 0;
    Text scoreText;
    
    void Start ()
    {
        scoreText = GetComponent<Text> ();
        Score = 0;
    }

    void Update ()
    {
        scoreText.text = "Score:" + Score;
    }
   

}
