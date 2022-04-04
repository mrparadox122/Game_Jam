using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovementScript_pl : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    private float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(dirX,0f);
       
    }
    void OnCollisionStay2D(Collision2D other) {
        if (other.gameObject.tag == "ground")
        {
             if (CrossPlatformInputManager.GetButtonDown("Jump"))
            {
            rb.AddForce(Vector2.up * 5500f);
            }
        }
    }
}
