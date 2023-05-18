using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Attack1 : MonoBehaviour
{
    public AnimationCurve animationCurve;
    public Vector3 originalPosition;
    private float time;
    public float duration;
    public float gunDuration;
    public GameObject projectile;
    public GameObject medpack;
    private Vector3 

    // Start is called before the first frame update
    void Awake()
    {
        transform.DOMoveY(-10f, gunDuration).SetRelative(true).SetLoops(-1, LoopType.Yoyo);
    }
    private void Update()
    {
        Instantiate(projectile, new Vector3(15, -12.47f, -8), Quaternion.Euler(new Vector3(90, 0, 0)));
    }
}
