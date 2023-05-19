using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Attack3 : MonoBehaviour
{
    public GameObject projectile;
    private Vector3 currentLocation;
    public int randomSpawn;
    public GameObject selfDestruction;
    public HP_system hp;
    public bossSpeedChanger boss;


    void Awake()
    {
        randomSpawn = Random.Range(1, 35);
        transform.position = new Vector3(12f - randomSpawn, 17f, 10f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentLocation = transform.position;
        boss.YPos = -0.7f/2;
        boss.XPos = 0.7f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -0.66f / 2;
        boss.XPos = 0.75f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -0.86f / 2;
        boss.XPos = 0.5f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -0.96f / 2;
        boss.XPos = 0.25f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -1f / 2;
        boss.XPos = 0f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -0.96f / 2;
        boss.XPos = -0.25f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -0.86f / 2;
        boss.XPos = -0.5f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -0.66f / 2;
        boss.XPos = -0.75f / 2;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.YPos = -0.7f / 2;  
        boss.XPos = -0.7f / 2   ;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        Destroy(selfDestruction);

    }
}
