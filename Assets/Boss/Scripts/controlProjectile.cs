using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class controlProjectile : MonoBehaviour
{
    void Awake()
    {
        transform.DOMoveX(-10f, 5f).SetRelative(true).SetLoops(-1, LoopType.Incremental);    
    }
}

