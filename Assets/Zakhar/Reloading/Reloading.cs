using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Reloading : MonoBehaviour
{
    private Animator anim;
    public float ammo = 30;




    void Start()
    {
        anim = GetComponent<Animator>();


    }




    void Update()
    {
        if (anim != null)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {

                anim.SetTrigger("Reload");
                



            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                if (ammo > 0)
                {
                    anim.SetTrigger("Shoot");
                    ammo--;
                }
            }
        }


    }

    public void ReloadingEvent()
    {
        ammo = 30;
    }
}
    


