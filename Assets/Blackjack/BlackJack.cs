using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackJack : MonoBehaviour
{
    public MoneyCount moneyCount;
    public ButtonsClickarooney ButtonsClickarooney;
    public cardData CardData;
    public GameObject objectToSpawn;
    int numberOfCard = 0;
    int deckk = 52;
    public int bet;
    public int[,] numbers;
    public int[,] player_hand = new int[2, 21];
    public int[,] second_hand = new int[2, 21];
    public int[,] dealer_hand = new int[2, 21];
    private System.Random _random = new System.Random();
    int ll = 0;
    int kk = 0;
    int b;
    int current_card;
    bool no_more_cards = false;
    public int ace_dealer;
    public int ace_player;
    public int ace_second;



    void Start()
    {
        bet = moneyCount.Money;
        numbers = new int[2, deckk];
        b = deckk;
        create_deck();
    }
    private void Update()
    {
        CardData.first_player_hand = player_hand;
        CardData.second_player_hand = second_hand;
        CardData.dealer_hand = dealer_hand;
        if (CardData.resetll == true)
        {
            ll = 1;
            CardData.resetll = false;
        }
    if (ButtonsClickarooney.GameStarted == 2)
        {
            player_hits(player_hand, ace_player);
            player_hits(player_hand, ace_player);
            dealer_hits();
            dealer_hits();
            CardData.round = 1;
            StartCoroutine(WaitCoroutine(2f));
            ButtonsClickarooney.GameStarted = 3;
        }
        if (ButtonsClickarooney.GameStarted == 5)
        {
            if (CardData.selected_action == 1)
            {
                if (CardData.second_hand == 3)
                {
                    player_hits(second_hand, ace_second);
                }
                else
                {
                    player_hits(player_hand, ace_player);
                }
                ButtonsClickarooney.GameStarted = 3;
                CardData.round = CardData.round + 1;
                StartCoroutine(WaitCoroutine(2f));

            }
            if (CardData.selected_action == 0)
            {
                if (CardData.second_hand != 2)
                {
                    if (CardData.second_hand == 3)
                    {
                        CardData.second_hand = 4;
                    }
                    no_more_cards = true;
                    CardData.no_more_cards = no_more_cards;
                    ButtonsClickarooney.GameStarted = 6;
                }
                else
                {
                    ll = 1;
                    CardData.second_hand = 3;
                    ButtonsClickarooney.GameStarted = 4;
                }
            }
            if (CardData.selected_action == 2)
            {
                player_hits(player_hand, ace_player);
                no_more_cards = true;
                CardData.no_more_cards = no_more_cards;
                moneyCount.moneyLeft = moneyCount.moneyLeft - moneyCount.currentBet;
                moneyCount.currentBet = moneyCount.currentBet * 2;
                ButtonsClickarooney.GameStarted = 3;
                StartCoroutine(WaitCoroutine(2f));
            }
            if (CardData.selected_action == 3)
            {
                ll = 0;
                CardData.second_hand = 1;
                CardData.second_player_hand[0, 0] = CardData.first_player_hand[0, 1];
                CardData.second_player_hand[1, 0] = CardData.first_player_hand[1, 1];
                CardData.first_player_hand[0, 1] = 0;
                CardData.first_player_hand[1, 1] = 0;
                if (CardData.second_player_hand[1, 0] == 1)
                {
                    CardData.second_player_hand[1, 0] = CardData.second_player_hand[1, 0] + 10;
                }
                ll = 1;
                CardData.selected_action = 1;
            }
        }
        if (ButtonsClickarooney.GameStarted == 6)
        {
            if (SumArray(dealer_hand) < 17)
            {
                dealer_hits();
                ButtonsClickarooney.GameStarted = 3;
                StartCoroutine(WaitCoroutine(1f));
            }
            else
            {
                CardData.ending = 1;
            }

        }
    }



    void create_deck()
    {
        int length = 0;
        while (length < deckk)
        {
            numbers[0, length] = length + 1;
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
            int t = array[0, r];
            array[0, r] = array[0, n];
            array[0, n] = t;
        }
    }
    void player_hits(int[,] card_hand, int aace_player)
    {
        b = b - 1;
        card_hand[0, ll] = numbers[0, b];
        current_card = card_hand[0, ll];
        CardData.ll = ll;
        if (ll == 1)
        {
            CardData.second_card = true;
        }
        if (current_card < 41 && current_card % 10 != 0)
        {
            current_card = current_card % 10;
            if (current_card % 10 != 1)
            {
                card_hand[1, ll] = current_card;
            }
            else
            {
                card_hand[1, ll] = 11;
            }

        }
        else
        {
            card_hand[1, ll] = 10;
        }
        CardData.player_hand = card_hand;
        CardData.whohits = 1;
        SpawnObject();
        Debug.Log(card_hand[0, ll] + ", " + card_hand[1, ll]);
        ll = ll + 1;
        if (SumArray(card_hand) > 21)
        {
            for (int i = 0; i < 21; i++)
            {
                if (card_hand[1, i] == 11)
                {
                    card_hand[1, i] = 1;
                    if (SumArray(card_hand) < 22)
                    {
                        return;
                    }
                }
            }
        }
    }
    void dealer_hits()
    {
        b = b - 1;
        dealer_hand[0, kk] = numbers[0, b];
        CardData.ll = kk;
        current_card = dealer_hand[0, kk];
        if (kk == 1)
        {
            CardData.hide_dealer_card = true;
        }
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
                ace_dealer = ace_dealer + 1;
            }

        }
        else
        {
            dealer_hand[1, kk] = 10;
        }
        CardData.player_hand = dealer_hand;
        CardData.whohits = 3;
        SpawnObject();
        Debug.Log(dealer_hand[0, kk] + ", " + dealer_hand[1, kk]);
        kk = kk + 1;
        if (SumArray(dealer_hand) > 21)
        {
            for (int i = 0; i < 21; i++)
            {
                if (dealer_hand[1, i] == 11)
                {
                    dealer_hand[1, i] = 1;
                    if (SumArray(dealer_hand) < 22)
                    {
                        return;
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
            sum = sum + toBeSummed[1, summedLength];
            summedLength = summedLength + 1;

        }
        return sum;
    }
    public void SpawnObject()
    {
        numberOfCard++;
        Instantiate(objectToSpawn, new Vector3(15, -12.47f, -8), Quaternion.Euler(new Vector3(90, 0, 0)), GameObject.FindGameObjectWithTag("Canvas").transform);
        CardData.numberOfCards = numberOfCard;
    }
    IEnumerator WaitCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        if (no_more_cards == false)
        {
            ButtonsClickarooney.GameStarted = 4;
        }
        else
        {
            ButtonsClickarooney.GameStarted = 6;
        }
    }
}
