using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 1.0f;
    public float maxSpeed = 5f;
    public float jumpHeight = 20f;
    private bool Jump = false; //my nama jeff

    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.velocity = new Vector2(moveSpeed, rb2d.velocity.y);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rb2d.velocity = new Vector2(-moveSpeed, rb2d.velocity.y);
        }
        else
        {
            rb2d.velocity = new Vector2(0f, rb2d.velocity.y);
        }

        if (Input.GetKeyDown("space") && !Jump)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(rb2d.velocity.x, jumpHeight);
            Jump = true;
        }
    }
/*
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Platform")
            Jump = false;

    }
*/
    /*
        bool canJump()
        {
            Ray raycast = new Ray(transform.position, -Vector3.up);
            return Physics.Raycast(raycast, 0.5f);
        }
        */
}