using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMovement : MonoBehaviour
{

    Rigidbody2D rb;

    public float jumpforce;
    public float speed;

    public bool grounded;

    public Transform groundCheck;
    public LayerMask groundLayer;
    public GameObject player;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        isGrounded();

        HorizontalMovement();

    }

    void isGrounded()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, .52f, groundLayer);
    }


    void HorizontalMovement()
    {
        if (grounded)
        {
            if (Input.GetKey(KeyCode.D) /*&& grounded*/)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }

            if (Input.GetKey(KeyCode.A) /*&& grounded*/)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
        else
        {
            float dragTime = 1f;
            dragTime = 0f;
            rb.velocity = new Vector2(dragTime, rb.velocity.y);
        }
    }
}
