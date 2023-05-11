using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkForMoves : MonoBehaviour
{
    public cardData CC;
    public MoneyCount moneyCount;
    public GameObject Double;
    public GameObject Split;
    void Start()
    {
        
    }

    void Update()
    {
        if (CC.round == 1)
        {
            if (moneyCount.moneyLeft >= moneyCount.currentBet)
            {
                Double.SetActive(true);
                if ((CC.first_player_hand[1, 0] == CC.first_player_hand[1, 1]) || (CC.first_player_hand[1, 0] == 11 && CC.first_player_hand[1, 1] == 1) || (CC.first_player_hand[1, 0] == 1 && CC.first_player_hand[1, 1] == 11))
                {
                    Split.SetActive(true);
                }
                else
                {
                    Split.SetActive(false);
                }
            }
            else
            {
                Double.SetActive(false);
            }
        }
        else
        {
            Double.SetActive(false);
            Split.SetActive(false);
        }
    }
}
