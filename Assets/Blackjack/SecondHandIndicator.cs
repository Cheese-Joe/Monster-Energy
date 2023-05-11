using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondHandIndicator : MonoBehaviour
{
    public cardData CC;
    public ButtonsClickarooney buttonsClickarooney;
    public GameObject firsthand;
    public GameObject secondhand;
    public int second_hand;
    void Start()
    {
        
    }

    void Update()
    {
        if (buttonsClickarooney.GameStarted == 4)
        {
            if (CC.second_hand == 3)
            {
                secondhand.SetActive(true);
                firsthand.SetActive(false);

            }
            else 
            {
                firsthand.SetActive(true);
                secondhand.SetActive(false);

            }

        }
        else
        {
            secondhand.SetActive(false);
            firsthand.SetActive(false);

        }
    }
}
