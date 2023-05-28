using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TempleScript : MonoBehaviour
{
    public TMP_Text counterText;
    public MoneyCount moneyCount;
    public TempleData templeData;
    public string[] donateTXT;
    public Button yourButton;


    private void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        moneyCount.Money = moneyCount.Money - moneyCount.currentBet;
        templeData.donation = templeData.donation + moneyCount.currentBet;
        if (templeData.donation >= 1000 && templeData.rainbow_bullet == false)
        {
            counterText.text = donateTXT[1];
            templeData.rainbow_bullet = true;
        }
        else if (templeData.donation >= 10000 && templeData.halo == false)
        {
            counterText.text = donateTXT[2];
            templeData.halo = true;

        }
        else if (templeData.donation >= 1000000 && templeData.immortality == false) 
        {
            counterText.text = donateTXT[3];
            templeData.immortality = true;

        }
        else
        {
            counterText.text = donateTXT[0];
        }
    }

}
