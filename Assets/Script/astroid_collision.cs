using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class astroid_collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("colla");
        if (other.gameObject.tag == "Player"){
            Destroy(other.gameObject);
            SceneManager.LoadScene(0);
        }
         
    }
}
