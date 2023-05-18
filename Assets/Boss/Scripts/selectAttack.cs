using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectAttack : MonoBehaviour
{
    public GameObject[] selectedAttack;
    private bool waitWait = false;
    public float waitForAttack;

    void Start()
    {
        
    }

    void Update()
    {
        if (!waitWait)
        {
            StartCoroutine(waitToAttack());
        }
    }
    IEnumerator waitToAttack()
    {
        waitWait = true;
        yield return new WaitForSeconds(waitForAttack);
        selectedAttack[0].SetActive(true);
        Instantiate(selectedAttack[0]);
        Debug.Log("aaa");
        waitWait = false;
    }
}
