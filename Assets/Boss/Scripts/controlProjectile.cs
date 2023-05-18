using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class controlProjectile : MonoBehaviour
{
    public GameObject selfdestruct;
    void Awake()
    {
        transform.DOMoveX(-100f, 10f).SetRelative(true).SetLoops(-1, LoopType.Incremental);
        Destroy(selfdestruct, 10f);
    }
}

