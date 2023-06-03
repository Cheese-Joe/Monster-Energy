using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Game Events/Data")]

public class MoneyCount : ScriptableObject
{
    public int Money;
    public int moneyLeft;
    public int currentBet;
    public int LVL;
    public int currentLVL;
    public bool gameBeaten;
    public bool shopOpened;
    public bool templeOpened;
    public bool[] chestOpened;
    public int chestCounter;
}
