using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpForce = 10f;
    public Transform groundCheck;
    public LayerMask groundLayer;
    bool isGrounded;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetKeyDown(KeyCode.Z) && isGrounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        if(isGrounded)
            animator.SetBool("isJumping", false);
        else
            animator.SetBool("isJumping", true);
    }
}