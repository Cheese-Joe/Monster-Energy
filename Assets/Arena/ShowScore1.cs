using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowScore1 : MonoBehaviour
{
    public TMP_Text counterText;
    public killCount KillCount;


    public void Update()
    {
        counterText.text = KillCount.score.ToString();
    }
}
