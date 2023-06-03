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
    public Slider slider;


    private void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick()
    {
        moneyCount.Money = moneyCount.Money - moneyCount.currentBet;
        templeData.donation = templeData.donation + moneyCount.currentBet;

        if (templeData.tomfoolery != 6)
        {
            if (moneyCount.currentBet > 0)
            {
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
            else
            {
                if (templeData.tomfoolery < 5)
                {
                    counterText.text = donateTXT[4];
                    templeData.tomfoolery++;

                }
                else if (templeData.tomfoolery == 5)
                {
                    counterText.text = donateTXT[5];
                    templeData.tomfoolery++;
                    templeData.donation = -500;
                    templeData.immortality = false;
                    templeData.halo = false;
                }
            }
        }
        else
        {
            if (templeData.donation < 0) 
            {
                counterText.text = donateTXT[6];
            }
            else
            {
                counterText.text = donateTXT[7];
                templeData.tomfoolery = 0;
            }
        }
        moneyCount.currentBet = 0;
        slider.value = 0;
        slider.maxValue = moneyCount.Money;

    }

}
