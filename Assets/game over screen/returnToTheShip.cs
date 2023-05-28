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
