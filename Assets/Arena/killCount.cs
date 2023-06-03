using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "KillCount", menuName = "Game Events/Kill Count")]

public class killCount : ScriptableObject
{
    public int KillCount;
    public float waitForAttack;
    public int score;
    public int round;
    public int highScore;
    public int[] highScoreLVL;
}
