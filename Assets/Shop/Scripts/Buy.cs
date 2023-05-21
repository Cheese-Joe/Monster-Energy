using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Buy : MonoBehaviour
{
    public Button yourButton;
    public GameObject nomoney;
    public string WhatToBuy;
    public int cost;
    public MoneyCount moneyCount;
    public HP_system hp;
    public int upgrade;
    public ShopData shopData;
    public int maxNumberOfUpgrades;

    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
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
            if (shopData.HP_upgrade < maxNumberOfUpgrades)
            {
                if (moneyCount.Money >= cost)
                {
                    moneyCount.Money = moneyCount.Money - cost;
                    hp.HP_max = hp.HP_max + upgrade;
                    shopData.HP_upgrade = shopData.HP_upgrade + 1;
                }
            }
        }
        if (WhatToBuy == "Gun")
        {
            if (shopData.Gun_upgrade < maxNumberOfUpgrades)
            {
                if (moneyCount.Money >= cost)
                {
                    moneyCount.Money = moneyCount.Money - cost;
                    hp.damage = hp.damage + upgrade;
                    shopData.Gun_upgrade = shopData.Gun_upgrade + 1;
                }
            }
        }
    }
}
