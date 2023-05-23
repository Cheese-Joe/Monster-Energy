using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowRound : MonoBehaviour
{
    public TMP_Text counterText;
    public killCount KillCount;


    public void Update()
    {
        counterText.text = KillCount.round.ToString();
    }
}
