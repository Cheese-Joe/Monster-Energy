using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectAttack : MonoBehaviour
{
    public GameObject[] selectedAttack;
    private bool waitWait = false;
    public float waitForAttack;
    public int randomAttack;

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
        randomAttack = Random.Range(0, selectedAttack.Length);
        Instantiate(selectedAttack[randomAttack]);
        Debug.Log("aaa");
        waitWait = false;
    }
}
