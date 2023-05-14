using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowMoney : MonoBehaviour
{
    public TMP_Text counterText;
    public MoneyCount moneyCount;
    private int counter = 0;


    public void Update()
    {
        counter = moneyCount.Money;
        counterText.text = counter.ToString();
    }

}
