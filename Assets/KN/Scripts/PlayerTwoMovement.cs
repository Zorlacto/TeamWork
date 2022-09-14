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

    public GameObject player;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        grounded = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        

        isGrounded();

        HorizontalMovement();

        

    }

    void HorizontalMovement()
    {
        if (grounded)
        {
            if (Input.GetKey(KeyCode.L) || Input.GetKey(KeyCode.RightArrow) /*&& grounded*/)
            {
                rb.velocity = new Vector2(speed, rb.velocity.y);
            }

            if (Input.GetKey(KeyCode.J) || Input.GetKey(KeyCode.LeftArrow) /*&& grounded*/)
            {
                rb.velocity = new Vector2(-speed, rb.velocity.y);
            }
        }
        /*else
        {
            float dragTime = 1f;
            dragTime = 7f;
            if (rb.velocity.x < 0)
            {
                rb.velocity = new Vector2(-dragTime, rb.velocity.y);
            }
            else if (rb.velocity.x > 0){
                rb.velocity = new Vector2(dragTime, rb.velocity.y);
            }
            
        }*/
    }

    void isGrounded()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, .52f, groundLayer);
    }

    private void OnDrawGizmos()
    {
        
        Gizmos.DrawSphere(transform.position, 0.55f);
    }

    /*void OnCollisionEnter2D(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }*/
}
