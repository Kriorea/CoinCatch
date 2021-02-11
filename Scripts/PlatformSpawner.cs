using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
   public Transform SpawnPos;
   public GameObject platform2;
    public GameObject platform3;
    
    
    

    void Start()
    {
      StartCoroutine(SpawnCD());
    }

    
    void Repeat()
    {
      StartCoroutine(SpawnCD());
    }
      IEnumerator SpawnCD()
      {
        yield return new WaitForSeconds(3);
        if(Random.Range(0,2) > 0) 
        {
        Instantiate(platform2, SpawnPos.position, Quaternion.identity);
        } else 
        {
         Instantiate(platform3, SpawnPos.position, Quaternion.identity); 
        }
        Repeat();
      }  
          
    
}
      
