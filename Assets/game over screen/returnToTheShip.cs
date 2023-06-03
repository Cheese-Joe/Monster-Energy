using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class returnToTheShip : MonoBehaviour
{
    public Button yourButton;
    public MoneyCount moneyCount;
    public int howManyLVLs;


    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        if (moneyCount.currentLVL == 1)
        {
            moneyCount.shopOpened = true;
        }
        if (moneyCount.currentLVL == 2)
        {
            moneyCount.templeOpened = true;
        }
    }
    void TaskOnClick()
    {
        if (!moneyCount.gameBeaten)
            moneyCount.currentLVL++;
        if (moneyCount.currentLVL > howManyLVLs)
            moneyCount.gameBeaten = true;
        SceneManager.LoadScene("Ship");
    }
}
