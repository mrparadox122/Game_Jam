using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mvmnt_Script : MonoBehaviour
{

      
    public float speed = 0.3f;
    public bool right;
    public bool ledt;
    

    // Start is called before the first frame update
    void Start()
    {
        right = false;
        ledt = false;

       


    }

    // Update is called once per frame
    void Update()
    {
      while(right){

         transform.Translate(speed,0,0);
         

    }
       while(ledt){
           transform.Translate(-speed,0,0);
       }
    }


    
    public void MoveRight(){
       Debug.Log("clicked");
    }
    public void MoveLecft(){
        Debug.Log("clicked");
        ledt = true;
    }
}
