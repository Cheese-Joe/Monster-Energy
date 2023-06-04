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
    private bool well;



    void FixedUpdate()
    {
        if (data.toGoal && !wait)
        {
            wait = true;
            StartCoroutine(ShowSpaceGirl());
        }
        if (data.toShooting && !waitWait)
        {
            waitWait = true;
            StartCoroutine(ShowSpaceGirl());
        }
    }
    IEnumerator ShowSpaceGirl()
    {
        well = true;
        for (int i = 0; i < 35; i++)
        {
            spaceGirl.transform.Translate(Vector3.right);
            yield return new WaitForSeconds(0.01f);
        }
        well = false;
    }
}
