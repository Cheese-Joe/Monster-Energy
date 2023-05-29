using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saveScore : MonoBehaviour
{
    public killCount kill;

    void Update()
    {
        if (kill.score > kill.highScoreLVL[kill.highScoreLVL.Length])
            kill.highScoreLVL[kill.highScoreLVL.Length] = kill.score;
    }
}
