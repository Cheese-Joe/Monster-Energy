using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Attack2 : MonoBehaviour
{
    public float gunDuration;
    public GameObject projectile;
    private Vector3 currentLocation;
    bool waitWait;
    public float waitForAttack;
    public int randomSpawn;
    private int attacks;
    public GameObject selfDestruction;
    public HP_system hp;
    public bossSpeedChanger boss;


    void Awake()
    {
        transform.DOMoveY(-10f, gunDuration).SetRelative(true).SetLoops(-1, LoopType.Yoyo);
    }
    private void Update()
    {
        if (!waitWait)
        {
            currentLocation = transform.position;
            StartCoroutine(waitToAttack());
        }
    }
    IEnumerator waitToAttack()
    {
        waitWait = true;
        yield return new WaitForSeconds(waitForAttack);
        boss.XPos = 0.7f;
        boss.YPos = 0.7f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 0.66f;
        boss.YPos = 0.75f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 0.86f;
        boss.YPos = 0.5f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 0.96f;
        boss.YPos = 0.25f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 1f;
        boss.YPos = 0f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 0.96f;
        boss.YPos = -0.25f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 0.86f;
        boss.YPos = -0.5f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 0.66f;
        boss.YPos = -0.75f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        boss.XPos = 0.7f;
        boss.YPos = -0.7f;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));


        attacks++;
        if (attacks == 10)
        {
            Destroy(selfDestruction);
        }
        waitWait = false;
    }
}
