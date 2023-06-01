using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Reloading : MonoBehaviour
{
    private Animator anim;
    public float ammo = 30;
    private bool waitWait;




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

            if ((Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse0)) && !waitWait)
            {
                if (ammo > 0)
                {
                    anim.SetTrigger("Shoot");
                    ammo--;

                    this.GetComponent<shootingNormal>().enabled = true;
                }

                if (ammo <= 0)
                {
                    this.GetComponent<shootingNormal>().enabled = false;

                    
                }
                StartCoroutine(reloads());
                
            }

            
        }


    }

    public void ReloadingEvent()
    {
        ammo = 30;
    }
    IEnumerator reloads()
    {
        waitWait = true;
        yield return new WaitForSeconds(0.4f);
        waitWait = false;
    }
}
    


