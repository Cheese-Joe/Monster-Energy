using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System.Runtime.InteropServices;
using Unity.VisualScripting;

public class Attack4 : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public float duration;
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
        transform.DOMoveX(30f, gunDuration).SetRelative(true).SetLoops(-1, LoopType.Yoyo);
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
        Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        attacks++;
        if (attacks == 5)
        {
            Destroy(selfDestruction);
        }
        waitWait = false;
    }
}

