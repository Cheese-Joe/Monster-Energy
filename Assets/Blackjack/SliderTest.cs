using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class SliderTest : MonoBehaviour
{
    public Slider sliderval;
    public MoneyCount moneyCount;
    private float checkVal;
    private bool waitWait;
    private AudioSource audioSource;
    public AudioClip audioo;

    void Start()
    {
        sliderval.maxValue = moneyCount.Money;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        moneyCount.currentBet = (int)sliderval.value;
        moneyCount.moneyLeft = moneyCount.Money - moneyCount.currentBet;
        if (Input.GetKeyDown(KeyCode.RightArrow) && (sliderval.value <= sliderval.maxValue))
        {
            sliderval.value = sliderval.value + 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (sliderval.value >= 0))
        {
            sliderval.value = sliderval.value - 1;
        }
        if (sliderval.value != checkVal)
        {
            if (!waitWait)
                StartCoroutine(PlaySound());
        }
    }
    IEnumerator PlaySound()
    {
        waitWait = true;
        audioSource.PlayOneShot(audioo, 0.6f);
        yield return new WaitForSeconds(0.7f);
        checkVal = sliderval.value;
        waitWait = false;
    }
}
