using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBet : MonoBehaviour
{
    public ButtonsClickarooney startGame;
    public GameObject objectsVisibleOnStart;
    public MoneyCount moneyCount;

    void Start()
    {
        
    }

    void Update()
    {
        if (startGame.GameStarted == 1)
        {
            if (moneyCount.currentBet > 0)
            {
                objectsVisibleOnStart.SetActive(true);
            }
            else
            {
                objectsVisibleOnStart.SetActive(false);
            }
        }
        else
        {
            objectsVisibleOnStart.SetActive(false);
        }
    }
}
