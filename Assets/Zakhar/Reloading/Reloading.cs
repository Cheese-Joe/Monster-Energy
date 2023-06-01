using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Reloading : MonoBehaviour
{
    private Animator anim;
    private bool waitWait;
    public HP_system hp;



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
                if (hp.ammo > 0)
                {
                    anim.SetTrigger("Shoot");
                    hp.ammo--;

                    this.GetComponent<shootingNormal>().enabled = true;
                }

                if (hp.ammo <= 0)
                {
                    this.GetComponent<shootingNormal>().enabled = false;

                    
                }
                StartCoroutine(reloads());
                
            }

            
        }


    }

    public void ReloadingEvent()
    {
        hp.ammo = hp.ammoMax;
    }
    IEnumerator reloads()
    {
        waitWait = true;
        yield return new WaitForSeconds(0.1f);
        waitWait = false;
    }
}
    


