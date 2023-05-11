using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class OnHit : MonoBehaviour
{
    public Button yourButton;
    public ButtonsClickarooney buttonsClickarooney;
    public cardData CC;
    public string whichbutton;
    public MoneyCount moneyCount;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        if (whichbutton == "hit")
        {
            CC.selected_action = 1;
            buttonsClickarooney.GameStarted = 5;
        }
        if (whichbutton == "stand")
        {
            CC.selected_action = 0;
            buttonsClickarooney.GameStarted = 5;
        }
        if (whichbutton == "double")
        {
            CC.selected_action = 2;
            buttonsClickarooney.GameStarted = 5;
        }
        if (whichbutton == "split")
        {
            CC.selected_action = 3;
            buttonsClickarooney.GameStarted = 5;
        }
    }
}
