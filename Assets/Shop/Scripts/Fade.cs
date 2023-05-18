using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour
{
    public GameObject buttonStart;

    // Start is called before the first frame update
    void Awake()
    {
        StartCoroutine(waitToDisable());
    }
    IEnumerator waitToDisable()
    {
        yield return new WaitForSeconds(3f);
        buttonStart.SetActive(false);
    }
}
