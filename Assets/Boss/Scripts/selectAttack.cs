using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectAttack : MonoBehaviour
{
    public GameObject[] selectedAttack;
    private bool waitWait = false;
    public float waitForAttack;
    public int randomAttack;
    public SpriteRenderer spriteRenderer;
    private int bossTired;
    public Sprite[] newSprite = new Sprite[4];
    public int newDawnFades;
    public HP_system hp_boss;
    public GameObject selfDestruct;
    private int randomNumberOFColorChanges;
    public HP_system hp;
    public bossSpeedChanger boss;
    void Start()
    {
        hp_boss.HP_current = hp_boss.HP_max;
    }

    void Update()
    {
        if (hp_boss.HP_current > 100)
        {
            hp_boss.HP_current = 100;
        }
        if (!waitWait)
        {
            StartCoroutine(waitToAttack());
        }
        if (hp_boss.HP_current < 1)
        {
            Destroy(selfDestruct);
        }
    }
    IEnumerator waitToAttack()
    {
        waitWait = true;
        if (newDawnFades !=0)
        {
            yield return new WaitForSeconds(waitForAttack);
        }
        else
        {
            yield return new WaitForSeconds(waitForAttack + hp_boss.HP_current / 20);
        }
        newDawnFades = 0;
        boss.bossColor = newDawnFades;
        spriteRenderer.sprite = newSprite[newDawnFades];
        randomAttack = Random.Range(0, selectedAttack.Length);
        Instantiate(selectedAttack[randomAttack]);
        Debug.Log("aaa");
        bossTired = Random.Range(0,2);
        if (bossTired == 1)
        {
            StartCoroutine(bossChill());
        }
        else
        {
            waitWait = false;

        }
    }
    IEnumerator bossChill()
    {
        yield return new WaitForSeconds(waitForAttack + hp_boss.HP_current / 20);
        newDawnFades = Random.Range(0, 4);
        boss.bossColor = newDawnFades;
        spriteRenderer.sprite = newSprite[newDawnFades];
        randomNumberOFColorChanges = Random.Range(1, 4);
        for (int i = 0; i < randomNumberOFColorChanges; i++)
        {
            yield return new WaitForSeconds(waitForAttack);
            newDawnFades = Random.Range(0, 4);
            spriteRenderer.sprite = newSprite[newDawnFades];
        }
        waitWait = false;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (newDawnFades != 0)
        {
            if (collision.transform.tag == "BlueBullet")
            {
                if (newDawnFades == 1)
                {
                    hp_boss.HP_current = hp_boss.HP_current - hp.damage;
                }
                else
                {
                    hp_boss.HP_current = hp_boss.HP_current + 3;
                }
            }
            if (collision.transform.tag == "RedBullet")
            {
                if (newDawnFades == 2)
                {
                    hp_boss.HP_current = hp_boss.HP_current - hp.damage;
                }
                else
                {
                    hp_boss.HP_current = hp_boss.HP_current + 3;
                }
            }
            if (collision.transform.tag == "GreenBullet")
            {
                if (newDawnFades == 3)
                {
                    hp_boss.HP_current = hp_boss.HP_current - hp.damage;
                }
                else
                {
                    hp_boss.HP_current = hp_boss.HP_current + 3;
                }
            }
        }
    }
}
