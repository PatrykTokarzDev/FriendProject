using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{


    //systems references
    Rigidbody2D rb;

    //handling
    public Vector2 savedVelocity;
    public float dashSpeed;
    private float dashTime;
    private float startDashTime;
    private int direction;
    


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
            
    }

    void Update () 
     {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(dashCoolDown());
        }
       
    }


    private IEnumerator dashCoolDown()
    {
        rb.velocity = Vector2.left * dashSpeed;
        yield return new WaitForSeconds(1);
        rb.velocity = Vector2.zero;

    }
 }
 
 

