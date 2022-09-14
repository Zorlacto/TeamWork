using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoMovement : MonoBehaviour
{

    Rigidbody2D rb;

    public float jumpforce;
    public float speed;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public bool grounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.J)) && grounded)
        {
            rb.velocity = new Vector2(0, jumpforce);
        }

        if (Input.GetKey(KeyCode.L) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(speed, 0);
        }
        if (Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-speed, 0);
        }
        
    }

    /*void isGrounded()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, 5f, groundLayer);
    }*/

    /*void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }*/
}
