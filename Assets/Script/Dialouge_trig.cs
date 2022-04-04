using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialouge_trig : MonoBehaviour
{

    private bool istriggered = false; 

    Dialuge dialuge;
     
    // Start is called before the first frame update
    void Start()
    {
        dialuge = FindObjectOfType<Dialuge>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("colla");
         dialuge.NextSentence();
         Destroy(this.gameObject);
    }




        
     
     void OnTriggerEnter( Collider coll)
     {
         if  (istriggered == false)
             // do your things here that has to happen once
             Debug.Log("collaasfdasd");
             istriggered = true;
     }
     
     void OnTriggerExit( Collider coll)
     {
         istriggered  = false;
     }

}
