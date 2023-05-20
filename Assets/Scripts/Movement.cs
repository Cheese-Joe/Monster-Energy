using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Subsystems;

public class Movement : MonoBehaviour
{
    public float speed = 8;
    public Animator animator;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float inputX;

    bool isGrounded;
    bool stop;
    private Animation go;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        inputX = Input.GetAxis("Horizontal");

        isGrounded = Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, groundLayer);


        Vector2 movement = new Vector2(speed * inputX, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

        if (inputX > 0)
        {
            gameObject.transform.localScale = new Vector3(1, 1, 0);
        }
        else if (inputX < 0)
        {
            gameObject.transform.localScale = new Vector3(-1, 1, 0);
        }

        if (inputX != 0)
        {
            animator.SetBool("isRunning", true);
            stop = true;
        }

        else
            animator.SetBool("isRunning", false);

       

      
    }

}