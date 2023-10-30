using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ClickStart : MonoBehaviour
{
    public Button yourButton;
    public GameObject buttonStart;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public ButtonsClickarooney buttonsClickarooney;
    public cardData CardData;

    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        buttonsClickarooney.GameStarted = 0;
        CardData.numberOfCards = 0;
        CardData.ll = 0;
        reset_arrays(CardData.player_hand);
        CardData.whohits = 0;
        reset_arrays(CardData.first_player_hand);
        reset_arrays(CardData.second_player_hand);
        reset_arrays(CardData.dealer_hand);
        CardData.round = 0;
        CardData.ending = 0;
        CardData.double_move = false;
        CardData.split_move = false;
        CardData.selected_action = 0;
        CardData.second_hand = 0;
        CardData.second_card = false;
        CardData.hide_dealer_card = false;
        CardData.no_more_cards = false;
        CardData.resetll = false;
        CardData.ending1 = 0;
        CardData.ending2 = 0;
        CardData.audioContinue = audioSource.time;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    void reset_arrays(int[,] toBeReseted)
    {
        int length = 0;
        while (length < toBeReseted.GetLength(0))
        {
            toBeReseted[0, length] = 0;
            length++;
        }
        while (length < toBeReseted.GetLength(1))
        {
            toBeReseted[1, length] = 0;
            length++;
        }
    }
}
