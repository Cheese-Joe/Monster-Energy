using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShowText4 : MonoBehaviour
{
    public TMP_Text counterText;
    public cardData CC;
    private int counter = 0;


    public void Update()
    {
        counter = CC.SumArray(CC.second_player_hand);
        counterText.text = counter.ToString();
    }

}
