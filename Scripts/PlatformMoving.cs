using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoving : MonoBehaviour
{
   public float move_Speed = 2f;
   public float bound_X = 7f;
   public bool StartPlatform, Platform2, Platform3, Platform4;

   


    void Start()
    {
        
    }

    
    void Update()
    {
        Move();
    }
    void Move() {

        transform.Translate(new Vector2(-1,0) * Time.deltaTime * move_Speed);

        if (transform.position.x <-20)
        {
            Destroy(gameObject);
        }
    } //move ends


}
