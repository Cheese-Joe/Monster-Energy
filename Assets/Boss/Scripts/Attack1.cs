using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Attack1 : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public Vector3 originalPosition;
    private float time;
    public float duration;
    public float gunDuration;
    public GameObject projectile;
    public GameObject medpack;
    private Vector3 currentLocation;
    bool waitWait;
    public float waitForAttack;
    public int randomSpawn;
    private int attacks;
    public GameObject selfDestruction;
    public HP_system hp;
    public bossSpeedChanger boss;


    // Start is called before the first frame update
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
        if (hp.HP_current < 3)
        {
            randomSpawn = Random.Range(0, 3);
        }
        else
        {
            randomSpawn = Random.Range(0, 6);
        }
        boss.XPos = 1f;
        boss.YPos = 0f;
        if (randomSpawn == 1)
        {
            Instantiate(medpack, currentLocation, Quaternion.Euler(new Vector3(0, -180, -180)));
        }
        else
        {
            Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
        }
        attacks++;
        if (attacks == 10)
        {
            Destroy(selfDestruction);
        }
        waitWait = false;
    }
}
