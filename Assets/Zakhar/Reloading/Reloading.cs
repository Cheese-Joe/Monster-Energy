using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Reloading : MonoBehaviour
{
    private Animator anim;
    private bool waitWait;
    public HP_system hp;
    public AudioClip[] audio;
    public AudioSource audioSource;

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
                audioSource.PlayOneShot(audio[0], 0.5f);
                anim.SetTrigger("Reload");
            }

            if ((Input.GetAxis("Fire2") == 1 || Input.GetAxis("Fire1") == 1) && !waitWait)
            {
                if (hp.ammo > 0)
                {
                    if (Input.GetAxis("Fire1") == 1)
                    {
                        anim.SetTrigger("Shoot");
                        hp.ammo--;
                    }

                    this.GetComponent<shootingNormal>().enabled = true;
                }

                if (hp.ammo <= 0)
                {
                    this.GetComponent<shootingNormal>().enabled = false;
                    audioSource.PlayOneShot(audio[1], 0.5f);


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
    


