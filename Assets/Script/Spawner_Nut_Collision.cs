using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Nut_Collision : MonoBehaviour
{
    // Start is called before the first frame update
    Astroid_spawn astroid;
    void Start()
    {
        astroid = FindObjectOfType<Astroid_spawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("colla");
        
         
    }


     void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("colla");
        astroid.SpaawnNuts();
    }
    void OnTriggerExit2D(Collider2D other) {
        Destroy(this.gameObject);
    }
}
