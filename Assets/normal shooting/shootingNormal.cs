using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingNormal : MonoBehaviour
{
    public GameObject[] projectiles;
    public HP_system hp;
    public Transform firePos;
    private bool waitWait;
    private float time;
    public TempleData temple;
    public GameObject rainbow;
    public AudioSource audioSource;
    public AudioClip[] clip;


    void Update()
    {
        if (!waitWait)
        {
            if (Input.GetAxis("Fire2") == 1 || temple.rainbow_bullet)
            {
                hp.current_gun = hp.current_gun + 1;
                if (hp.current_gun >= projectiles.Length)
                {
                    hp.current_gun = 0;
                }
                time = 0.5f;
            }
            if (Input.GetAxis("Fire1") == 1)
            {
                if (!temple.rainbow_bullet)
                {
                    audioSource.PlayOneShot(clip[hp.current_gun], 0.3f);
                    Instantiate(projectiles[hp.current_gun], firePos.position, firePos.rotation);
                }
                else
                {
                    Instantiate(rainbow, firePos.position, firePos.rotation);
                    audioSource.PlayOneShot(clip[3], 0.3f);
                }
                time = 0.2f;
            }
            StartCoroutine(noSpam());
        }
    }
    IEnumerator noSpam()
    {
        waitWait = true;
        yield return new WaitForSeconds(time);
        time = 0f;
        waitWait = false;
    }
}
