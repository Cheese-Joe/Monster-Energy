using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public HP_system hp;
    public int damage;
    public bool destroyOnCollision;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            hp.HP_current = hp.HP_current - damage;
            Debug.Log("Player");
            if (destroyOnCollision )
            {
                Destroy(this.gameObject);
            }
        }
    }
}
