using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPos : MonoBehaviour
{
    public ShipData ship;
    public Vector3 pos;


    void Start()
    {
        ship.position = pos;
    }
}
