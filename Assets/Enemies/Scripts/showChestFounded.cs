using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showChestFounded : MonoBehaviour
{
    public bool currentMax;
    public MoneyCount data;
    public TMP_Text counterText;


    private void Awake()
    {
        if (!currentMax)
        {
            counterText.text = data.chestCounter.ToString();
        }
        else
        {
            counterText.text = data.chestOpened.Length.ToString();
        }
    }
}
