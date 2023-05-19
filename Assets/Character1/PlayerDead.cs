using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    public HP_system hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp.HP_current <0)
        {
            hp.HP_current = hp.HP_max;
            Debug.Break();
    
        }

    }
}
