using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coin;

    public float coin_Spawn_Timer = 1f;
    private float current_coin_Spawn_Timer;

    private int coin_Spawn_Count;
    public float min_Y =-0.21f, max_Y = 4.24f;



    void Start()
    {
      current_coin_Spawn_Timer = coin_Spawn_Timer;
    }

    void Update() 
    {
       SpawnCoins();
    }

    void SpawnCoins() 
    {
        current_coin_Spawn_Timer += Time.deltaTime;
      if(current_coin_Spawn_Timer >= coin_Spawn_Timer){
        
          coin_Spawn_Count++;

Vector3 temp = transform.position;
          temp.y = Random.Range(min_Y, max_Y);
          GameObject newCoin = null;
          if(coin_Spawn_Count < 2) {
              if(Random.Range(0,2) > 0) {
                newCoin = Instantiate(coin, temp, Quaternion.identity);
              } 
            coin_Spawn_Count = 0;
          }
          current_coin_Spawn_Timer = 0f;
      }





    }





}
