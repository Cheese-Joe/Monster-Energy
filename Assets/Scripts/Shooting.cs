using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public float bulletSpeed = 5f;
    public Transform firePos;
    private int weapon = 1;

    void Update()
    {
        if(weapon == 1 && Input.GetKeyDown(KeyCode.C) || weapon == 1 && Input.GetKeyDown(KeyCode.Q))
        {
            weapon = 2;
        }
        else if(weapon == 2 && Input.GetKeyDown(KeyCode.C) || weapon == 2 && Input.GetKeyDown(KeyCode.Q))
        {
            weapon = 3;
        }
        else if(weapon == 3 && Input.GetKeyDown(KeyCode.C) || weapon == 3 && Input.GetKeyDown(KeyCode.Q))
        {
            weapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.E))
        {
            Shoot();
        }

        void Shoot()
        {
            if(weapon == 1)
            {
                GameObject bullet = Instantiate(bullet1, firePos.position, firePos.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * bulletSpeed;
            }
            else if(weapon == 2)
            {
                GameObject bullet = Instantiate(bullet2, firePos.position, firePos.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * bulletSpeed;
            }
            else if(weapon == 3)
            {
                GameObject bullet = Instantiate(bullet3, firePos.position, firePos.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * bulletSpeed;
            }
            
        }
    }

    //gameObject.transform.Rotate(0, 0, 0);
}