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
    public GameObject selfDestructBody;
    public GameObject selfDestructWall;
    public GameObject Ship;
    private int randomNumberOFColorChanges;
    public HP_system hp;
    public bossSpeedChanger boss;
    private Animator animator;
    public AudioClip hitSound;
    public AudioClip healSound;
    public GameObject death;
    private AudioSource audioSource;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        hp_boss.HP_current = hp_boss.HP_max;
        animator = GetComponent<Animator>();
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
            Ship.SetActive(true);
            Instantiate(death);
            Destroy(selfDestructWall);
            Destroy(selfDestructBody);
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
        animator.SetBool(newDawnFades, true);
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
            animator.SetBool(newDawnFades, true);
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
                    audioSource.PlayOneShot(hitSound, 0.6f);
                    hp_boss.HP_current = hp_boss.HP_current - hp.damage;
                }
                else
                {
                    audioSource.PlayOneShot(healSound, 0.6f);
                    hp_boss.HP_current = hp_boss.HP_current + 3;
                }
            }
            if (collision.transform.tag == "RedBullet")
            {
                if (newDawnFades == 2)
                {
                    audioSource.PlayOneShot(hitSound, 0.6f);
                    hp_boss.HP_current = hp_boss.HP_current - hp.damage;
                }
                else
                {
                    audioSource.PlayOneShot(healSound, 0.6f);
                    hp_boss.HP_current = hp_boss.HP_current + 3;
                }
            }
            if (collision.transform.tag == "GreenBullet")
            {
                if (newDawnFades == 3)
                {
                    audioSource.PlayOneShot(hitSound, 0.6f);
                    hp_boss.HP_current = hp_boss.HP_current - hp.damage;
                }
                else
                {
                    audioSource.PlayOneShot(healSound, 0.6f);
                    hp_boss.HP_current = hp_boss.HP_current + 3;
                }
            }
            if (collision.transform.tag == "Fireball")
            {
                audioSource.PlayOneShot(hitSound, 0.6f);
                hp_boss.HP_current = hp_boss.HP_current - hp.damage;
            }

        }
    }
}
