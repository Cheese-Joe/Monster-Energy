using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class showWhatsNew : MonoBehaviour
{
    public TMP_Text counterText;
    public MoneyCount moneyCount;
    public string[] text;


    public void Start()
    {
        if (!moneyCount.gameBeaten)
        {
            counterText.text = text[moneyCount.currentLVL];
        }
    }
}
