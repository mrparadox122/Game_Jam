using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroid_spawn : MonoBehaviour
{
    float randX;
    float randXNuts;
    Vector2 whereToSpawn;
    Vector2 whereToSpawnNuts;
    public GameObject astroid;
    public GameObject Nuts;


    


    
    
   public void SpawnAstroid(){
        StartCoroutine(ExampleCoroutine());
    }
    public void SpaawnNuts(){
         StartCoroutine(ExampleCoroutineNut());
    }



       IEnumerator ExampleCoroutine()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.5f);
         randX = Random.Range (56.5f,43.3f);
         whereToSpawn = new Vector2 (randX,transform.position.x);
         Instantiate (astroid,whereToSpawn,Quaternion.identity); 
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }



     IEnumerator ExampleCoroutineNut()
    {
        //Print the time of when the function is first called.
        Debug.Log("Started Coroutine at timestamp : " + Time.time);

        //yield on a new YieldInstruction that waits for 5 seconds.
        yield return new WaitForSeconds(0.2f);
         randXNuts = Random.Range (250.7f,251.0f);
         whereToSpawnNuts = new Vector2 (randXNuts,transform.position.x);
         Instantiate (Nuts,whereToSpawnNuts,Quaternion.identity); 
        //After we have waited 5 seconds print the time again.
        Debug.Log("Finished Coroutine at timestamp : " + Time.time);
    }



    
}
