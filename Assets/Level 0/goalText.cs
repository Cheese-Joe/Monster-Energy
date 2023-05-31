using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class goalText : MonoBehaviour
{
    public TutorialData data;
    public GameObject spaceGirl;

    private void Awake()
    {
        data.toGoal = true;
    }
}
