using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePos;
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject bullet3;
    public HP_system hp;

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Q) && hp.current_gun == 1 || Input.GetKeyDown(KeyCode.C) && hp.current_gun == 1)
        {
            hp.current_gun = 2;
        }
        else if(Input.GetKeyDown(KeyCode.Q) && hp.current_gun == 2 || Input.GetKeyDown(KeyCode.C) && hp.current_gun == 2)
        {
            hp.current_gun = 3;
        }
        else if (Input.GetKeyDown(KeyCode.Q) && hp.current_gun == 3 || Input.GetKeyDown(KeyCode.C) && hp.current_gun == 3)
        {
            hp.current_gun = 1;
        }

        if (Input.GetKeyDown(KeyCode.E) && hp.current_gun == 1 || Input.GetKeyDown(KeyCode.X) && hp.current_gun == 1)
            Instantiate(bullet, firePos.position, firePos.rotation);
        else if (Input.GetKeyDown(KeyCode.E) && hp.current_gun == 2 || Input.GetKeyDown(KeyCode.X) && hp.current_gun == 2)
            Instantiate(bullet2, firePos.position, firePos.rotation);
        else if (Input.GetKeyDown(KeyCode.E) && hp.current_gun == 3 || Input.GetKeyDown(KeyCode.X) && hp.current_gun == 3)
            Instantiate(bullet3, firePos.position, firePos.rotation);
    }
}
