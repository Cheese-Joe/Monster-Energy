using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowHighScore1 : MonoBehaviour
{
    public TMP_Text counterText;
    public killCount KillCount;
    public int whichLVL;

    public void Start()
    {
        if (whichLVL >=0)
        {
            counterText.text = KillCount.highScoreLVL[whichLVL].ToString();
        }
        else
        {
            counterText.text = KillCount.highScore.ToString();
        }
    }
}