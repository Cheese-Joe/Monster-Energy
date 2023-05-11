using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ending : MonoBehaviour
{
    public TMP_Text counterText;
    public TMP_Text counterText1;
    public TMP_Text counterText2;

    public cardData CC;
    public ButtonsClickarooney buttonsClickarooney;
    public GameObject objectsVisibleOnStart;
    public GameObject objectsVisibleOnStart1;
    public GameObject objectsVisibleOnStart2;
    public MoneyCount moneyCount;
    public int ending1;
    public int ending2;
    public int ends;
    bool first_busted;
    bool second_busted;

    void Start()
    {
        
    }

    void Update()
    {
        if (buttonsClickarooney.GameStarted > 3 && buttonsClickarooney.GameStarted < 10)
        {
            if (CC.second_hand > 1)
            {
                if (first_busted == false)
                {
                    if ((SumArray(CC.dealer_hand) > 21))
                    {
                        objectsVisibleOnStart1.SetActive(true);
                        counterText1.text = ("House is busted!");
                        CC.ending1 = 2;
                    }
                    if ((CC.ending == 1))
                    {
                        objectsVisibleOnStart1.SetActive(true);
                        if ((SumArray(CC.first_player_hand) > SumArray(CC.dealer_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.first_player_hand) < 22))
                        {
                            counterText1.text = ("Player won!");
                            CC.ending1 = 2;
                        }
                        if ((SumArray(CC.dealer_hand) > SumArray(CC.first_player_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.first_player_hand) < 22))
                        {
                            counterText1.text = ("House won!");
                            CC.ending1 = 1;
                        }
                        if ((SumArray(CC.dealer_hand) == SumArray(CC.first_player_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.first_player_hand) < 22))
                        {
                            counterText1.text = ("Draw!");
                            CC.ending1 = 3;
                        }
                        ends = 1;
                    }
                }
                if ((SumArray(CC.second_player_hand) > 21))
                {
                    objectsVisibleOnStart2.SetActive(true);
                    counterText2.text = ("Player is busted!");
                    buttonsClickarooney.GameStarted = 10;
                    second_busted = true;
                    CC.second_hand = 4;
                    if (SumArray(CC.first_player_hand) < 22) 
                    {
                        CC.no_more_cards = true;
                        buttonsClickarooney.GameStarted = 6;
                    }
                }
                if (second_busted == false)
                {
                    if ((SumArray(CC.dealer_hand) > 21))
                    {
                        objectsVisibleOnStart2.SetActive(true);
                        counterText2.text = ("House is busted!");
                        buttonsClickarooney.GameStarted = 10;
                        CC.ending2 = 2;
                    }
                }
                if ((CC.ending == 1))
                {
                    if (second_busted == false)
                    {
                        objectsVisibleOnStart2.SetActive(true);
                        if ((SumArray(CC.second_player_hand) > SumArray(CC.dealer_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.second_player_hand) < 22))
                        {
                            counterText2.text = ("Player won!");
                            buttonsClickarooney.GameStarted = 10;
                            CC.ending = 2;
                            CC.ending2 = 2;

                        }
                        if ((SumArray(CC.dealer_hand) > SumArray(CC.second_player_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.second_player_hand) < 22))
                        {
                            counterText2.text = ("House won!");
                            buttonsClickarooney.GameStarted = 10;
                            CC.ending = 2;
                            CC.ending2 = 1;


                        }
                        if ((SumArray(CC.dealer_hand) == SumArray(CC.second_player_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.second_player_hand) < 22))
                        {
                            counterText2.text = ("Draw!");
                            buttonsClickarooney.GameStarted = 10;
                            CC.ending = 2;
                            CC.ending2 = 3;
                        }
                    }
                }
                if ((first_busted == true) && (second_busted == true))
                {
                    CC.ending1 = 1;
                    CC.ending2 = 1;
                }
                if ((second_busted == true) && (CC.ending1 != 0))
                {
                    CC.ending2 = 1;
                }
                if ((first_busted == true) && (CC.ending2 != 0))
                {
                    CC.ending1 = 1;
                }
            }
            else
            {
                if ((CC.round == 1) && (CC.first_player_hand[1, 0] + CC.first_player_hand[1, 1] == 21) && (CC.dealer_hand[1, 0] + CC.dealer_hand[1, 1] != 21))
                {
                    CC.no_more_cards = true;
                    objectsVisibleOnStart.SetActive(true);
                    counterText.text = ("BlackJack!");
                    buttonsClickarooney.GameStarted = 10;
                    CC.ending1 = 4;
                }
                if ((SumArray(CC.first_player_hand) > 21))
                {
                    objectsVisibleOnStart.SetActive(true);
                    counterText.text = ("Player is busted!");
                    buttonsClickarooney.GameStarted = 10;
                    CC.ending1 = 1;
                }
                if ((SumArray(CC.dealer_hand) > 21))
                {
                    objectsVisibleOnStart.SetActive(true);
                    counterText.text = ("House is busted!");
                    buttonsClickarooney.GameStarted = 10;
                    CC.ending1 = 2;
                }
                if ((CC.ending == 1))
                {
                    objectsVisibleOnStart.SetActive(true);
                    if ((SumArray(CC.first_player_hand) > SumArray(CC.dealer_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.first_player_hand) < 22))
                    {
                        counterText.text = ("Player won!");
                        buttonsClickarooney.GameStarted = 10;
                        CC.ending = 2;
                        CC.ending1 = 2;

                    }
                    if ((SumArray(CC.dealer_hand) > SumArray(CC.first_player_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.first_player_hand) < 22))
                    {
                        counterText.text = ("House won!");
                        buttonsClickarooney.GameStarted = 10;
                        CC.ending = 2;
                        CC.ending1 = 1;

                    }
                    if ((SumArray(CC.dealer_hand) == SumArray(CC.first_player_hand)) && (SumArray(CC.dealer_hand) < 22) && (SumArray(CC.first_player_hand) < 22))
                    {
                        counterText.text = ("Draw!");
                        buttonsClickarooney.GameStarted = 10;
                        CC.ending = 2;
                        CC.ending1 = 3;
                    }
                }

            }
            if (CC.second_hand == 2)
            {
                if ((SumArray(CC.first_player_hand) > 21))
                {
                    objectsVisibleOnStart1.SetActive(true);
                    counterText1.text = ("Player is busted!");
                    CC.second_hand = 3;
                    buttonsClickarooney.GameStarted = 4;
                    CC.resetll = true;
                    first_busted = true;
                }
            }
        }
        if (CC.ending1 == 1)
        {
            moneyCount.Money = moneyCount.Money - moneyCount.currentBet;
            CC.ending1 = 0;
            buttonsClickarooney.GameStarted = 10;
            CC.score = CC.score - moneyCount.currentBet;
        }
        else if (CC.ending1 == 2)
        {
            moneyCount.Money = moneyCount.Money + moneyCount.currentBet;
            CC.ending1 = 0;
            CC.score = CC.score + moneyCount.currentBet;
            buttonsClickarooney.GameStarted = 10;

        }
        else if (CC.ending1 == 4)
        {
            moneyCount.Money = moneyCount.Money + (moneyCount.currentBet / 2 * 3);
            CC.ending1 = 0;
            CC.score = CC.score + (moneyCount.currentBet / 2 * 3);
            buttonsClickarooney.GameStarted = 10;

        }
        if (CC.ending2 == 1)
        {
         moneyCount.Money = moneyCount.Money - moneyCount.currentBet;
            CC.ending2 = 0;
            CC.score = CC.score - moneyCount.currentBet;
            buttonsClickarooney.GameStarted = 10;


        }
        else if (CC.ending2 == 2)
        {
            moneyCount.Money = moneyCount.Money + moneyCount.currentBet;
            CC.ending2 = 0;
            CC.score = CC.score + moneyCount.currentBet;
            buttonsClickarooney.GameStarted = 10;
        }
    }
    public int SumArray(int[,] toBeSummed)
    {
        int sum = 0;
        int summedLength = 0;
        while (summedLength < 21)
        {
            sum = sum + toBeSummed[1, summedLength];
            summedLength = summedLength + 1;

        }
        return sum;
    }
}
