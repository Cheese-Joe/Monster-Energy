using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondHandUI : MonoBehaviour
{
    public cardData CC;
    public GameObject objectsVisibleOnStart;
    public int second_hand;
    void Start()
    {
        
    }

    void Update()
    {
        if (CC.second_hand > second_hand)
        {
            objectsVisibleOnStart.SetActive(true);
        }
    }
}
