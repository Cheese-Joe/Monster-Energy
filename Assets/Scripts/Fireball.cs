using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float bulletSpeed;
    Rigidbody2D rb;
    public Transform Check;
    public LayerMask groundLayer;

    bool check;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();        
        rb.velocity = transform.right * bulletSpeed;
    }

    void Update()
    {
        check = Physics2D.OverlapCapsule(Check.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, groundLayer);

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            bulletSpeed = -30;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            bulletSpeed = 30;
        }

        if (check)
            Destroy(gameObject);
    }
}
