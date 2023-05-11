using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class StartGame : MonoBehaviour
{
    public Button yourButton;
    public ButtonsClickarooney buttonsClickarooney;
    public GameObject buttonStart;
    public cardData CardData;


    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        buttonsClickarooney.GameStarted = buttonsClickarooney.GameStarted+1;
        buttonStart.SetActive(false);
    }
}
