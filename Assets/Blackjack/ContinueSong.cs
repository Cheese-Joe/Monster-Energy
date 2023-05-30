using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueSong : MonoBehaviour
{
    private AudioSource audioSource;
    public cardData CC;


    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.time = CC.audioContinue;
    }

}
