using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarMovement : MonoBehaviour
{

    //variable declaration
    public Vector2 speed2 = new Vector2(30, 30);
    private float speed = 10;
    public float jumpHeight = 50;
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

        Vector2 movement = new Vector2(horizontal*speed2.x, 0);

        //rb.AddForce(movement * speed);

        movement *= Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetAxis("Jump") > 0)
        {
            transform.Translate(Vector2.up * jumpHeight * Time.deltaTime, Space.World);
        }


    }
}