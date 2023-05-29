using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startPos : MonoBehaviour
{
    public ShipData shipData;
    public GameObject player;
    public MoneyCount moneyCount;
    public GameObject[] unlocks;
    public GameObject[] lights;

    void Start()
    {
        player.transform.position = shipData.position;
        if (!moneyCount.shopOpened)
        {
            unlocks[0].GetComponent<yourPos>().enabled = false;
            lights[0].SetActive(false);
        }
        if (!moneyCount.templeOpened)
        {
            unlocks[1].GetComponent<yourPos>().enabled = false;
            lights[1].SetActive(false);
        }
    }
}
