using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovingPlatforms : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public Vector3 originalPosition;
    private float time;
    public float duration;
    public float direction;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = transform.position;
        transform.DOMoveX(direction, duration).SetRelative(true).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
