using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float bulletSpeed;
    Rigidbody2D rb;
    public Transform lCheck;
    public Transform rCheck;
    public LayerMask groundLayer;

    bool rcheck;
    bool lcheck;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
        rb.velocity = transform.right * bulletSpeed;
    }

    void Update()
    {
        rcheck = Physics2D.OverlapCapsule(rCheck.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, groundLayer);
        lcheck = Physics2D.OverlapCapsule(lCheck.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            bulletSpeed = -30;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            bulletSpeed = 30;
        }

        if (rcheck || lcheck)
            Destroy(gameObject);
    }
}
