using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarMovement : MonoBehaviour
{
    //variable declaration
    private float speed = 10;
    public float jumpHeight = 5;
    Rigidbody2D rb;



    /// <summary>
    /// Gets the rigidBody component of the avatar sprite
    /// </summary>
    private void Awake()
    {


        rb = transform.GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Gets the input controls 
    /// adds momentum when pressing A,D or Left arrow, right arrow
    /// space key increases height
    /// </summary>
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, 0);

        rb.AddForce(movement * speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector2.up * jumpHeight;
        }


    }
}