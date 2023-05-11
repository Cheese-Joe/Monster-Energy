using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class ShowText2 : MonoBehaviour
{
    public TMP_Text counterText;
    public cardData CC;
    private int counter = 0;



    public void Update()
    {
        if (CC.no_more_cards == true)
        {
            counter = CC.SumArray(CC.dealer_hand);
            counterText.text = counter.ToString();
        }
        else
        {
            counter = CC.dealer_hand[1,0];
            if ((CC.dealer_hand[1,0] == 11) || (CC.dealer_hand[1,0] == 1))
            {
                counterText.text = ("11");
            }
            else
            {
                counterText.text = counter.ToString();
            }
        }

    }

}
