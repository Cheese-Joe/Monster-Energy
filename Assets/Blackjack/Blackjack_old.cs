using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;


public class Blackjack_old : MonoBehaviour
{
    public MoneyCount moneyCount;
    public cardData CardData;
    int deckk = 52;
    public int bet;
    public int[,] numbers;
    public int[,] player_hand = new int[2, 21];
    public int[,] second_hand = new int[2, 21];
    public int[,] dealer_hand = new int[2, 21];
    private System.Random _random = new System.Random();
    int ll = 0;
    int kk = 0;
    int ss = 0;
    int b;
    int current_bet = 0;
    int round = 0;
    int current_card;
    int prize = 0;
    bool no_more_cards = false;
    int second_hand_bool = 0;
    int showdebug = 0;
    bool lost = false;



    void Start()
    {
        bet = moneyCount.Money;
        numbers = new int[2,deckk];
        b = deckk;
        DebugLog();
    }
    private void Update()
    {
        place_bet();
        if (round > 0)
        {
            gameplay();
            DebugLog();
        }

    }


    void create_deck()
    {
        int length = 0;
        while (length < deckk)
        {
            numbers[0,length] = length + 1;
            length++;
        }
        Shuffle(numbers);
    }

    void Shuffle(int[,] array)
    {
        int p = array.GetLength(1);
        for (int n = p - 1; n > 0; n--)
        {
            int r = _random.Next(0, n);
            int t = array[0,r];
            array[0,r] = array[0,n];
            array[0,n] = t;
        }
    }
    void player_hits(int[,] card_hand)
    {
        b = b - 1;
        card_hand[0,ll] = numbers[0,b];
        current_card = card_hand[0,ll];
        CardData.ll = ll;
        CardData.player_hand = card_hand;
        if (current_card < 41 && current_card % 10 != 0)
        {
            current_card = current_card % 10;
            if (current_card % 10 != 1)
            {
                player_hand[1, ll] = current_card;
            }
            else
            {
                player_hand[1, ll] = 11;

            }

        }
        else
        {
            card_hand[1,ll] = 10;
        }
        Debug.Log(card_hand[0,ll]+", "+ card_hand[1,ll]);
        ll = ll + 1;
        
    }
    void dealer_hits()
    {
        b = b - 1;
        dealer_hand[0,kk] = numbers[0,b];
        current_card = dealer_hand[0, kk];
        if (current_card < 41 && current_card % 10 != 0)
        {
            current_card = current_card % 10;
            if (current_card % 10 != 1)
            {
                dealer_hand[1, kk] = current_card;
            }
            else
            {
                dealer_hand[1, kk] = 11;

            }

        }
        else
        {
            dealer_hand[1, kk] = 10;
        }
        Debug.Log("Dealer Hand: ");
        Debug.Log(dealer_hand[0, kk] + ", " + dealer_hand[1, kk]);
        kk = kk + 1;
    }
    void place_bet()
    {
    if (round == 0)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (bet > 0)
                {
                    bet = bet - 1;
                    current_bet = current_bet + 1;
                    moneyCount.Money = bet;
                    DebugLog();
                }
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (current_bet > 0)
                {
                    bet = bet + 1;
                    current_bet = current_bet - 1;
                    moneyCount.Money = bet;
                    DebugLog();
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (round == 0)
            {
                create_deck();
                player_hits(player_hand);
                player_hits(player_hand);
                dealer_hits();
                dealer_hits();
                round = 1;
            }
        }
    }
    void gameplay()
    {
        if (no_more_cards == false)
        {
            if (round == 1)
            {
                blackjack(player_hand);
                split();
                double_down();
            }
            if (round > 0)
            {
                stand();
                hit();
            }
        }
        else
        {
            if (SumArray(player_hand) > 21)
            {
                Debug.Log("Busted! You lose.");
                round = 0;
                lost = true;
            }
            if (second_hand_bool > 0 && second_hand_bool < 3)
            {
                if (SumArray(second_hand) > 21)
                {
                    Debug.Log("Busted! You lose.");
                    round = 0;
                }
                else
                {
                    second_hand_bool = 3;
                }
            }
            else
            {
               if (lost == false)
                {
                    while (SumArray(dealer_hand) < 16)
                    {
                        dealer_hits();
                    }
                    if (SumArray(dealer_hand) > 21)
                    {
                        prize = current_bet;
                        Debug.Log("House got busted! You win! Your bet:" + current_bet + ". Your prize: " + prize);
                        bet = bet + current_bet + prize;
                        current_bet = 0;
                        prize = 0;
                        round = 0;
                    }
                    else if (SumArray(player_hand) > SumArray(dealer_hand))
                    {
                        prize = current_bet;
                        Debug.Log("You got closer to 21! You win! Your bet:" + current_bet + ". Your prize: " + prize);
                        bet = bet + current_bet + prize;
                        current_bet = 0;
                        prize = 0;
                        round = 0;
                    }
                    else
                    {
                        prize = 0;
                        Debug.Log("House got closer to 21! You loose! Your bet:" + current_bet + ". Your prize: " + prize);
                        round = 0;
                    }
                    if (second_hand_bool == 3)
                    {
                        if (SumArray(player_hand) > SumArray(dealer_hand))
                        {
                            prize = current_bet;
                            Debug.Log("You got closer to 21! You win! Your bet:" + current_bet + ". Your prize: " + prize);
                            bet = bet + current_bet + prize;
                            current_bet = 0;
                            prize = 0;
                            round = 0;
                        }
                        else
                        {
                            prize = 0;
                            Debug.Log("House got closer to 21! You loose! Your bet:" + current_bet + ". Your prize: " + prize);
                            round = 0;
                        }
                    }
                }
            }
        }
    }
    public int SumArray(int[,] toBeSummed)
    {
        int sum = 0;
        int summedLength = 0;
        while (summedLength < 21)
        {
            sum = sum + toBeSummed[1,summedLength];
            summedLength = summedLength + 1;

        }
        return sum;
    }
    void blackjack(int[,] card_hand)
    {
        if ( card_hand[1, 0] + card_hand[1, 1] == 21)
        {
            if (dealer_hand[1, 1] != 21)
            {
                prize = current_bet / 2 * 3;
                Debug.Log("BlackJack! Your bet: " + current_bet + ". Your prize: " + prize);
                bet = bet + current_bet + prize;
                current_bet = 0;
                prize = 0;
            }
            else
            {
                Debug.Log("Draw.");
                bet = bet + current_bet + prize;
                current_bet = 0;
                prize = 0;
            }
            round = 0;
        }
    }
    void split()
    {
        if (player_hand[1, 0] == player_hand[1, 1])
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                second_hand_bool = 1;
                second_hand[0, 0] = player_hand[0, 1];
                ll = ll - 1;
                player_hits(player_hand);
                round = round + 1;
            }
        }
    }
    void hit()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (second_hand_bool == 2)
            {
                player_hits(second_hand);
            }
            else
            {
                player_hits(player_hand);
            }
            round = round + 1;
            if (SumArray(player_hand) > 20)
            {
                if (second_hand_bool > 0 && second_hand_bool < 3)
                {
                    if (second_hand_bool == 1)
                    {
                        ll = 0;
                        player_hits(second_hand);
                        round = 1;
                    }
                    second_hand_bool = 2;
                }
                else
                {
                    no_more_cards = true;
                }
            }
        }
    }
    void double_down()
    {
        if (bet > current_bet)
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                bet = bet - current_bet;
                current_bet = current_bet * 2;
                player_hits(player_hand);
                no_more_cards = true;
            }
        }
    }
    void stand()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            if (second_hand_bool == 2)
            {
                no_more_cards = true;
                round = round + 1;
            }
            if (second_hand_bool > 0 && second_hand_bool < 3)
            {
                if (second_hand_bool == 1)
                {
                    player_hits(second_hand);
                    round = 1;
                }
                second_hand_bool = 2;
            }
            else
            {
                no_more_cards = true;
                round = round + 1;
            }
        }
    }
    void DebugLog()
    {
        if (round != showdebug || showdebug ==0)
        {
            showdebug = round;
            Debug.Log("Your money: " + bet + ". Current bet: " + current_bet);
            if (round == 1)
            {
                if (player_hand[1, 0] == player_hand[1, 1])
                {
                    Debug.Log("Press Tab to split pair of cards.");
                }
                Debug.Log("Press Ctrl to double your bet.");

            }
            if (round > 0)
            {
                Debug.Log("Press Shift to stand.");
                Debug.Log("Press Space to hit.");
            }
        }
    }
}
