using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bullet : MonoBehaviour
{
    public HP_system hp;


    void Start()
    {
        transform.DOMoveX(100f * hp.direction, 10f).SetRelative(true).SetLoops(-1, LoopType.Incremental);
        Destroy(gameObject, 2f);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag != transform.tag)
            Destroy(gameObject);
    }
}
