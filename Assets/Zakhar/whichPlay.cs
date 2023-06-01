using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whichPlay : MonoBehaviour
{
    public MoneyCount data;
    public GameObject[] buttons;


    void Awake()
    {
        if (data.currentLVL == 0 && !data.gameBeaten)
        {
            buttons[1].SetActive(false);
            buttons[0].SetActive(true);

        }
        else
        {
            buttons[1].SetActive(true);
            buttons[0].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
