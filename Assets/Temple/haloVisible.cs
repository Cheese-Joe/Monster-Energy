using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haloVisible : MonoBehaviour
{
    public TempleData temple;
    public GameObject halo;

    private void Awake()
    {
        if (temple.halo)
        {
            halo.SetActive(true);
        }
        else
        {
            halo.SetActive(false);
        }
    }
}
