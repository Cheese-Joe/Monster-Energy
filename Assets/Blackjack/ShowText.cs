using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowText : MonoBehaviour
{
    public TMP_Text counterText;
    public MoneyCount moneyCount;


    public void Update()
    {
        counterText.text = moneyCount.moneyLeft.ToString();
    }
}
