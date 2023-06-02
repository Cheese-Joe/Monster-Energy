using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class showAmmo : MonoBehaviour
{
    public bool currentMax;
    public HP_system data;
    public TMP_Text counterText;


    // Start is called before the first frame update
    void Awake()
    {
            if (!currentMax)
            {
                counterText.text = data.ammo.ToString();
            }
            else
            {
                counterText.text = data.ammoMax.ToString();
            }
    }

    // Update is called once per frame
    void Update()
    {
        if (!currentMax)
        {
            counterText.text = data.ammo.ToString();
        }
    }
}
