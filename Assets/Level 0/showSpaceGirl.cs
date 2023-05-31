using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class showSpaceGirl : MonoBehaviour
{
    private bool wait;
    public TutorialData data;
    public GameObject spaceGirl;
    private bool waitWait;


    void Update()
    {
        if (data.toGoal && !wait)
        {
            wait = true;
            spaceGirl.transform.DOMoveX(40, 1f).SetRelative(true).SetLoops(2, LoopType.Incremental);
        }
        if (data.toShooting && !waitWait)
        {
            waitWait = true;
            spaceGirl.transform.DOMoveX(46f, 1f).SetRelative(true).SetLoops(2, LoopType.Incremental);
        }
    }
}
