using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePos;
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public int weapon = 1;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C) && weapon == 1)
        {
            weapon = 2;
        }
        else if(Input.GetKeyDown(KeyCode.C) && weapon == 2)
        {
            weapon = 3;
        }
        else if (Input.GetKeyDown(KeyCode.C) && weapon == 3)
        {
            weapon = 1;
        }

        if (Input.GetKeyDown(KeyCode.X) && weapon == 1)
            Instantiate(bullet, firePos.position, firePos.rotation);
        else if (Input.GetKeyDown(KeyCode.X) && weapon == 2)
            Instantiate(bullet2, firePos.position, firePos.rotation);
        else if (Input.GetKeyDown(KeyCode.X) && weapon == 3)
            Instantiate(bullet3, firePos.position, firePos.rotation);
    }
}
