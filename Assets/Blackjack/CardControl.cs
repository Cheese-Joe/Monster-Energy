using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour
{
    public float speed = 10f;
    public cardData CC;
    float coroutinewait = 50;
    int currentcard;
    int currentcard1;
    public SpriteRenderer spriteRenderer;
    public Sprite[] newSprite = new Sprite[53];
    public int ll;
    public int[,] cards = new int[2, 21];
    public bool second_card;
    public bool hide_dealer_card;
    public float RotationSpeed = 50f;
    private AudioSource audioSource;
    public AudioClip clip;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        hide_dealer_card = CC.hide_dealer_card;
        CC.hide_dealer_card = false;
        second_card = CC.second_card;
        CC.second_card = false;
        currentcard = CC.ll +1;
        Vector3 posLoc = new Vector3(30 + (-6 * currentcard), -12.47f, 0);
        StartCoroutine(MoveCard());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if ((second_card == true) && (CC.second_hand == 1))
        {
            StartCoroutine(MoveSecondCard1());
            second_card=false;
            CC.second_hand = 2;
        }
        if (hide_dealer_card == true && CC.no_more_cards == true)
        {
            StartCoroutine(RotateCard());
            hide_dealer_card =false;
        }
    }
    IEnumerator MoveCard()
    {
        currentcard1 = currentcard;
        ll = CC.ll;
        cards = CC.player_hand;
        if (CC.whohits == 1)
        {
            for (int x = 1; x <= coroutinewait; x++)
            {
                yield return new WaitForSeconds(0.01f);
                transform.Translate(-new Vector3(0, -speed * 2, 0));
            }
        }
        if (currentcard > 9)
        {
            for (int x = 1; x <= coroutinewait * 0.25f; x++)
            {
                yield return new WaitForSeconds(0.01f);
                transform.Translate(-new Vector3(0, -speed, 0));
            }
            currentcard1 = currentcard1 - 3;
        }
        if (currentcard > 6)
        {
            for (int x = 1; x <= coroutinewait * 0.25f; x++)
            {
                yield return new WaitForSeconds(0.01f);
                transform.Translate(-new Vector3(0, -speed, 0));
            }
            currentcard1 = currentcard1 - 3;
        }

        if (currentcard > 3)
        {
            for (int x = 1; x <= coroutinewait * 0.25f; x++)
            {
                yield return new WaitForSeconds(0.01f);
                transform.Translate(-new Vector3(0, -speed, 0));
            }
            currentcard1 = currentcard1 - 3;
        }


        for (int x = 1; x <= coroutinewait; x++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Translate(-new Vector3(speed * currentcard1, 0, 0.0001f * currentcard));
        }
        if (CC.second_hand == 3)
        {
            StartCoroutine(MoveSecondCard());
        }
        Debug.Log(cards[0, ll]);
        if (hide_dealer_card == false)
        {
            StartCoroutine(RotateCard());
        }
    }
    IEnumerator MoveSecondCard()
    {
        for (int x = 1; x <= coroutinewait; x++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Translate(-new Vector3(0.4f, 0, 0));
        }
    }
    IEnumerator MoveSecondCard1()
    {
        for (int x = 1; x <= coroutinewait; x++)
        {
            yield return new WaitForSeconds(0.01f);
            transform.Translate(-new Vector3(0.3f, 0, 0));
        }
    }
    public void changeSpriteVoid(int ll)
    {
        spriteRenderer.sprite = newSprite[ll];
    }
    IEnumerator RotateCard()
    {
        audioSource.PlayOneShot(clip, 0.3f);
        float goofy = 1;
        for (int x = 1; x <= coroutinewait * 0.25f; x++)
        {
            yield return new WaitForSeconds(0.01f);
            goofy = goofy * 0.5f;
            transform.localScale = new Vector3(goofy, 1, 1);
            Debug.Log(goofy);
        }
        changeSpriteVoid(cards[0, ll]);
        for (int x = 1; x <= coroutinewait * 0.25f; x++)
        {
            goofy = goofy * 2f;
            yield return new WaitForSeconds(0.01f);
            transform.localScale = new Vector3(1f, 1, 1);
        }
    }

}
