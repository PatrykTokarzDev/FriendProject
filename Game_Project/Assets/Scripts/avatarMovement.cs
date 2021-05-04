using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avatarMovement : MonoBehaviour
{

    //variable declaration
    private Vector2 speed2 = new Vector2(30, 30);
    private float speed = 5f;
    private float jumpHeight = 50;
    Rigidbody2D rb;

    private float MovementSmoothing = 0.001f; //FOR OPTION 2 THIS VARIABLE IS WHAT TO CHANGE TO ADD MOMENTUM, THE LOWER THE NUMBER THE LESS MOMENTUM BUT DO NOT PUT IT TO 0 OR ABOVE 1 
    private Vector3 velMove = Vector3.zero;

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


        ///
        /// OPTION 1
        ///

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += move * Time.deltaTime * speed;



        ///
        /// OPTION 2
        ///
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 targetVelocity = new Vector2(horizontal * 10f, rb.velocity.y);
        rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref velMove, MovementSmoothing);













        ///
        /// OPTION 3
        ///
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(horizontal*speed2.x, 0);

        ////rb.AddForce(movement * speed);

        //movement *= Time.deltaTime;
        ////transform.Translate(movement);

        //transform.position += movement * (Time.deltaTime * 5);
        //if (Input.GetAxis("Jump") > 0)
        //{
        //    transform.Translate(Vector2.up * jumpHeight * Time.deltaTime, Space.World);
        //}


    }








}