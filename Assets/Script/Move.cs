using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    Rigidbody2D rb;
    bool FacingLeft = true;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float inputMove = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(inputMove * Speed, rb.velocity.y);
        Orientation(inputMove);
    }

    void Orientation(float inputMove)
    {
        if ((FacingLeft == true && inputMove < 0) || (FacingLeft == false && inputMove > 0))
        {
            FacingLeft = !FacingLeft;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
