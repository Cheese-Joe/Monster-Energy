using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class craterattack : MonoBehaviour
{
    private bool waitWait;
    public float waitForAttack;
    public bossSpeedChanger boss;
    public GameObject projectile;
    public float XPos;
    public float YPos;
    private Vector3 currentLocation;

    private void Awake()
    {
        currentLocation = transform.position;
    }
    void Update()
    {
        if (!waitWait)
        {
            StartCoroutine(meteorsfalling());
        }
    }
    IEnumerator meteorsfalling()
    {
        waitWait = true;
        yield return new WaitForSeconds(waitForAttack);
        boss.XPos = XPos;
        boss.YPos = YPos;
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));

        waitWait = false;

    }
}
