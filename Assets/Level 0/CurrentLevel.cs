using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevel : MonoBehaviour
{
    public int whichLvlIsIt;
    public MoneyCount moneyCount;

    void Awake()
    {
        moneyCount.currentLVL = whichLvlIsIt;
    }


}
