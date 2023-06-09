using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestController : MonoBehaviour
{
    public MoneyCount money;
    public int howMuchMoney;
    public AudioSource audioSource;
    public AudioClip coinClick;
    public GameObject canvas;
    public GameObject chest;


    // Start is called before the first frame update
    void Awake()
    {
        if (money.chestOpened[money.currentLVL] == true)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            audioSource.PlayOneShot(coinClick, 0.5f);
            money.Money = money.Money + howMuchMoney;
            money.chestOpened[money.currentLVL] = true;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            money.chestCounter++;
            chest.SetActive(false);
            canvas.SetActive(true);
            Destroy(gameObject, 2f);
        }
    }
}
