using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class nextTutorialPage : MonoBehaviour
{
    public TutorialData data;
    public GameObject spaceGirl;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            data.toShooting = true;
            Destroy(gameObject);
        }
    }
}
