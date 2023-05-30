using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Card Data", menuName = "Game Events/Card Data")]



public class cardData : ScriptableObject
{
    public int numberOfCards;
    public int ll;
    public int[,] player_hand = new int[2,21];
    public int whohits;
    public int[,] first_player_hand = new int[2, 21];
    public int[,] second_player_hand = new int[2, 21];
    public int[,] dealer_hand = new int[2, 21];
    public int round;
    public int ending;
    public bool double_move;
    public bool split_move;
    public int selected_action;
    public int second_hand;
    public bool second_card;
    public bool hide_dealer_card;
    public bool no_more_cards;
    public bool resetll;
    public int ending1;
    public int ending2;
    public int score;
    public float audioContinue;

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
