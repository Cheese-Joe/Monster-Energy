using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibleOnGameStart : MonoBehaviour
{
    public ButtonsClickarooney startGame;
    public GameObject objectsVisibleOnStart;
    public int whenBecameVisible;
    public string equalless;
    void Start()
    {
        
    }

    void Update()
    {
        if (equalless=="equal")
        {
            if (startGame.GameStarted == whenBecameVisible)
            {
                objectsVisibleOnStart.SetActive(true);
            }
            else
            {
                objectsVisibleOnStart.SetActive(false);
            }
        }
        if (equalless == "less")
        {
            if (startGame.GameStarted <= whenBecameVisible)
            {
                objectsVisibleOnStart.SetActive(true);
            }
            else
            {
                objectsVisibleOnStart.SetActive(false);
            }
        }
        if (equalless == "more")
        {
            if (startGame.GameStarted >= whenBecameVisible)
            {
                objectsVisibleOnStart.SetActive(true);
            }
            else
            {
                objectsVisibleOnStart.SetActive(false);
            }
        }
    }
}
