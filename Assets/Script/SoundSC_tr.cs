using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSC_tr : MonoBehaviour
{
    public AudioClip saw;   
     
     void Start ()   
     {
         GetComponent<AudioSource> ().playOnAwake = false;
         GetComponent<AudioSource> ().clip = saw;
     }        
     void OnTriggerEnter2D(Collider2D other) {
         if (other.gameObject.tag == "s")
         {
            GetComponent<AudioSource> ().Play ();     
         }
        
    }
}
