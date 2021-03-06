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
        //rb.constraints = RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.None;
        dashTime = startDashTime;

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            StartCoroutine(dashCoolDown());
        }

    }


    private IEnumerator dashCoolDown()
    {
       // rb.constraints = RigidbodyConstraints2D.FreezePositionY;
        //rb.velocity = Vector2.left * dashSpeed;
        rb.gravityScale = 0f;
        rb.AddForce(Vector3.left * 10000);
        yield return new WaitForSeconds(0.1f);
        rb.velocity = Vector3.zero;
        rb.gravityScale = 1f;
        //rb.constraints = RigidbodyConstraints2D.FreezeRotation;
        


        //PROBLEM: when the player uses this script the Y or vertical does not lock. Sometimes the player also stops moving completely
    }
}
 
 

