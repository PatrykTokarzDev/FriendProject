using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float fallMultipier = 2.5f;
    public float lowJumpMultplier = 2f;
    Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.y < 0)
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (fallMultipier - 1) * Time.deltaTime;

        }
        else if (rb.velocity.y > 0 && !Input.GetKeyDown("Jump"))
        {
            rb.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultplier - 1) * Time.deltaTime;
        }

    }
}
