using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CharMotor : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 moveInput;
    public Rigidbody2D rb;

    private float activeMoveSpeed;
    public float dashSpeed;

    public float dashLength = 1f, dashCooldown = 1f;

    public float dashCounter;
    private float dashCoolCounter;
    void Start()
    {
        activeMoveSpeed = moveSpeed;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb.velocity = moveInput * activeMoveSpeed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (dashCounter <= 0 && dashCoolCounter <=0)
            {
                activeMoveSpeed = dashSpeed;
                dashCounter = dashLength;
            }
        }

        if (dashCounter <= 0)
        {
            dashCounter -= Time.deltaTime;

            if (dashCounter <= 0)
            {
                activeMoveSpeed = moveSpeed;
                dashCoolCounter = dashCooldown;
            }
        }
        if (dashCoolCounter >0)
        {
            dashCoolCounter -= Time.deltaTime;
        }
    }
}
