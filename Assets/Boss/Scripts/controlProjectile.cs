using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class controlProjectile : MonoBehaviour
{
    public GameObject selfdestruct;
    public bossSpeedChanger boss;



    void Awake()
    {
        transform.DOMoveX(-100f * boss.XPos, 10f).SetRelative(true).SetLoops(-1, LoopType.Incremental);
        transform.DOMoveY(-100f * boss.YPos, 10f).SetRelative(true).SetLoops(-1, LoopType.Incremental);

        Destroy(selfdestruct, 10f);
    }
}

