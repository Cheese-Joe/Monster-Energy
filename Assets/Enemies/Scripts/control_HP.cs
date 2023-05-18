using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;


public class control_HP : MonoBehaviour
{
    public Slider sliderval;
    public HP_system hp;
    // Start is called before the first frame update
    void Start()
    {
        sliderval.maxValue = hp.HP_max;
    }

    void Update()
    {
        sliderval.value = hp.HP_current;
    }
}
