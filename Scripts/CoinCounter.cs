using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    public bool coin;
    void OnTriggerEnter2D(Collider2D target)
{
    if(target.tag == "Player") {
        if(coin) {
            
            Destroy(gameObject);
            ScoreCount.Score += 1;
        }
    }  
} 
}
