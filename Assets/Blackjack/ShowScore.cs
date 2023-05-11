using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowScore : MonoBehaviour
{
    public TMP_Text counterText;
    public cardData CC;
    private int counter = 0;


    public void Update()
    {
        counter = CC.score;
        counterText.text = counter.ToString();
    }
}
