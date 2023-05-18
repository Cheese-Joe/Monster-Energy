using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;



public class Buy : MonoBehaviour
{
    public Button yourButton;
    public GameObject nomoney;
    public string WhatToBuy;
    public int cost;
    public MoneyCount moneyCount;
    public HP_system hp;
    public int upgrade;
    public Upgrades upgrades;
    public int maxUpgrade;
    public TMP_Text counterText;

    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        if (WhatToBuy == "hp")
        {
            if (upgrades.HPUpgrade >= maxUpgrade)
            {
                counterText.text = "MAX.";
            }
        }
        if (WhatToBuy == "damage")
        {
            if (upgrades.DamageUpgrade >= maxUpgrade)
            {
                counterText.text = "MAX.";
            }
        }
    }

    void TaskOnClick()
    {
        if (moneyCount.Money < cost)
        {
            nomoney.SetActive(true);
        }
        if (WhatToBuy == "medpack")
        {
            if (moneyCount.Money >= cost)
            {
                moneyCount.Money = moneyCount.Money - cost;
                hp.HP_current = hp.HP_current + upgrade;
            }
        }
        if (WhatToBuy == "hp")
        {
            if (upgrades.HPUpgrade < maxUpgrade)
            {
                if (moneyCount.Money >= cost)
                {
                    moneyCount.Money = moneyCount.Money - cost;
                    hp.HP_current = hp.HP_current + upgrade;
                    upgrades.HPUpgrade = upgrades.HPUpgrade + 1;

                }
            }

        }
        if (WhatToBuy == "damage")
        {
            if (upgrades.DamageUpgrade < maxUpgrade)
            {
                if (moneyCount.Money >= cost)
                {
                    moneyCount.Money = moneyCount.Money - cost;
                    upgrades.DamageUpgrade = upgrades.DamageUpgrade + 1;
                }
            }
        }
        if (WhatToBuy == "hp")
        {
            if (upgrades.HPUpgrade >= maxUpgrade)
            {
                counterText.text = "MAX.";
            }
        }
        if (WhatToBuy == "damage")
        {
            if (upgrades.DamageUpgrade >= maxUpgrade)
            {
                counterText.text = "MAX.";
            }
        }
    }
}
