using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class lightFlickering : MonoBehaviour
{
    public GameObject lightFlicker;
    private bool waitWait;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!waitWait)
        {
            StartCoroutine(lights());
        }
    }


    IEnumerator lights()
    {
        waitWait = true;
        lightFlicker.GetComponent<Light>().intensity = 13;
        yield return new WaitForSeconds(0.5f);
        lightFlicker.GetComponent<Light>().intensity = 8;
        yield return new WaitForSeconds(0.5f);
        waitWait = false;
    }
}
