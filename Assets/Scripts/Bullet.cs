using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Vector2 direction;
    private float speed;
    public Transform check;
    public LayerMask groundLayer;

    public void SetDirection(Vector2 direction)
    {
        this.direction = direction;
    }

    public void SetSpeed(float speed)
    {
        this.speed = speed;
    }

    private void Update()
    {
        Move();

        if (Physics2D.OverlapCapsule(check.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, groundLayer))
            Destroy(gameObject);
    }

    private void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
