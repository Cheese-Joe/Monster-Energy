using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingFixed : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject bullet2;
    public GameObject bullet3;
    public float bulletSpeed = 5f;
    public Transform firePos;
    public HP_system hp;


    void Update()
    {
        if(hp.current_gun == 1 && Input.GetKeyDown(KeyCode.C) || hp.current_gun == 1 && Input.GetKeyDown(KeyCode.Q))
        {
            hp.current_gun = 2;
        }
        else if(hp.current_gun == 2 && Input.GetKeyDown(KeyCode.C) || hp.current_gun == 2 && Input.GetKeyDown(KeyCode.Q))
        {
            hp.current_gun = 3;
        }
        else if(hp.current_gun == 3 && Input.GetKeyDown(KeyCode.C) || hp.current_gun == 3 && Input.GetKeyDown(KeyCode.Q))
        {
            hp.current_gun = 1;
        }

        if (Input.GetKeyDown(KeyCode.X) || Input.GetKeyDown(KeyCode.E))
        {
            Shoot();
        }

        void Shoot()
        {
            if(hp.current_gun == 1)
            {
                GameObject bullet = Instantiate(bullet1, firePos.position, firePos.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * bulletSpeed;
            }
            else if(hp.current_gun == 2)
            {
                GameObject bullet = Instantiate(bullet2, firePos.position, firePos.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * bulletSpeed;
            }
            else if(hp.current_gun == 3)
            {
                GameObject bullet = Instantiate(bullet3, firePos.position, firePos.rotation);
                Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
                rb.velocity = transform.right * bulletSpeed;
            }
            
        }
    }

}