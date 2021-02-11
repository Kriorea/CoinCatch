using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounds : MonoBehaviour
{

    public float min_X = -4.74f, max_X = -4.74f, min_Y = -8f, max_Y = 3.81f;
  

    void Update()
    {
      CheckBounds();  
    }
    void CheckBounds () {

    Vector2 temp = transform.position;
        if (temp.y > max_Y)
            temp.y = max_Y;
        if (temp.y < min_Y)
            temp.y = min_Y; 
        if (temp.x > max_X)
            temp.x = max_X;
        if (temp.x < min_X)
            temp.x = min_X;  
        transform.position = temp;


    } 





} 