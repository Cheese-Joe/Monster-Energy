using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapWind : MonoBehaviour
{
    public Animator animator;
    public int weapon = 1;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && weapon == 1)
        {
            weapon = 2;
        }
        else if (Input.GetKeyDown(KeyCode.C) && weapon == 2)
        {
            weapon = 3;
        }
        else if (Input.GetKeyDown(KeyCode.C) && weapon == 3)
        {
            weapon = 1;
        }

        if (weapon == 1)
        {
            animator.SetBool("fireswap", true);
        }
        else if (weapon == 2)
        {
            animator.SetBool("freezeswap", true);
        }
        else if (weapon == 3)
        {
            animator.SetBool("gearswap", true);
        }
    }
}
