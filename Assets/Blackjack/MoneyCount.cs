using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "Game Events/Data")]

public class MoneyCount : ScriptableObject
{
    public int Money;
    public int moneyLeft;
    public int currentBet;
}
