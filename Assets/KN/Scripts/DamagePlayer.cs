using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    

    PlayerTwoMovement playerTwoMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerTwoMovement = GetComponent<PlayerTwoMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("hit player");
            GameObject.FindObjectOfType<PlayerTwoMovement>().UpdateHealth();
        }
    }
}
