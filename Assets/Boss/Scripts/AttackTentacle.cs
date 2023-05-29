using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AttackTentacle : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public Vector3 originalPosition;
    private float time;
    public float duration;
    public int selectTentacle;
    public GameObject[] tentacles;
    public GameObject selfdestruct;
    public RandomiseBetter randomiseBetter;

    // Start is called before the first frame update
    void Awake()
    {
        while (randomiseBetter.RandomiseTentacle == selectTentacle)
        {
            selectTentacle = Random.Range(0, 3);
        }
        randomiseBetter.RandomiseTentacle = selectTentacle;
        originalPosition = transform.position;
       tentacles[selectTentacle].transform.DOMoveX(50f, duration).SetRelative(true).SetLoops(2, LoopType.Yoyo);
        Destroy(selfdestruct, 20f);
    }
}
