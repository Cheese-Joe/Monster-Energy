using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevel : MonoBehaviour
{
    public int whichLvlIsIt;
    public MoneyCount moneyCount;
    public killCount kill;
    void Awake()
    {
        moneyCount.currentLVL = whichLvlIsIt;
        kill.score = 0;
    }


}
