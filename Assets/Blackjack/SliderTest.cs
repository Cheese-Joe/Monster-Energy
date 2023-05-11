using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SliderTest : MonoBehaviour
{
    public Slider sliderval;
    public MoneyCount moneyCount;
    public ButtonsClickarooney startGame;


    void Start()
    {
        sliderval.maxValue = moneyCount.Money;
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
    }
}
