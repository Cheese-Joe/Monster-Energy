using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ArenaController : MonoBehaviour
{
    private bool waitWait;
    public float waitForAttack;
    public GameObject[] enemies;
    private Vector3[] currentLocation;
    public GameObject[] enemyLocations;
    public MoneyCount money;
    private int moneyBefore;
    public int numberOfSpawns;
    private int ll;
    private int kk;
    public GameObject[] activateCraters;
    private int nn;
    public killCount KillCount;
    public GameObject medpack;
    private Vector3 medpackLocation;

    void Awake()
    {
        moneyBefore = money.Money;
        currentLocation = new Vector3[enemyLocations.Length];
        KillCount.KillCount = 0;
        KillCount.score = 0;
        KillCount.round = 0;
        medpackLocation = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!waitWait)
        {
            if (KillCount.KillCount == numberOfSpawns)
            {
                StartCoroutine(meteorsfalling());
            }
        }
    }
    IEnumerator meteorsfalling()
    {
        KillCount.round = KillCount.round + 1;
        numberOfSpawns = numberOfSpawns + KillCount.round * 3;
        waitWait = true;
        yield return new WaitForSeconds(waitForAttack);
        for (int i = 0; i < KillCount.round * 3; i++)
        {
            ll = Random.Range(0, enemies.Length);
            kk = Random.Range(0, currentLocation.Length);
            currentLocation[kk] = enemyLocations[kk].transform.position;
            Instantiate(enemies[ll], currentLocation[kk], Quaternion.Euler(new Vector3(0, 0, 0)));
            yield return new WaitForSeconds(2f);
        }
        if (KillCount.round > 4)
        {
            for   (int i = 0; i < activateCraters.Length;i++)
            {
                nn = Random.Range(0, 3);
                if (nn == 1)
                {
                    activateCraters[i].GetComponent<craterattack>().enabled = true;
                }
                else
                {
                    activateCraters[i].GetComponent<craterattack>().enabled = false;
                }
            }
        }
        if (KillCount.round > 2)
        {
            Instantiate(medpack, new Vector3(-0.05f, 8.5f, 0), Quaternion.Euler(new Vector3(0, -180, -180)));
        }
        waitWait = false;

    }
}
