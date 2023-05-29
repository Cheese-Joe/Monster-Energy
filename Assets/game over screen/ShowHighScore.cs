using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore : MonoBehaviour
{
    public TMP_Text counterText;
    public killCount KillCount;
    public MoneyCount moneyCount;


    public void Start()
    {
        if (KillCount.highScoreLVL[moneyCount.currentLVL] <= KillCount.score)
        {
            KillCount.highScoreLVL[moneyCount.currentLVL] = KillCount.score;
        }
        counterText.text = KillCount.highScoreLVL[moneyCount.currentLVL].ToString();
    }
}