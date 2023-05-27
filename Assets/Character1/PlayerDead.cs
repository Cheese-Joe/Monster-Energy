using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDead : MonoBehaviour
{
    public HP_system hp;
    public Transform dzCheck;
    public LayerMask dzLayer;

    void Update()
    {
        if (hp.HP_current <0)
        {
            hp.HP_current = hp.HP_max;
            Debug.Break();
        }
        else if(Physics2D.OverlapCapsule(dzCheck.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, dzLayer))
        {
            Debug.Break();
        }
    }
}
