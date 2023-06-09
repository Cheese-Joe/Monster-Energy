using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public HP_system hp;
    public int damage;
    public bool destroyOnCollision;
    public GameObject soundSpawn;
    private Vector3 currentLocation;
    public TempleData temple;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (temple.tomfoolery == 6)
            {
                damage = 9999;
            }
            hp.HP_current = hp.HP_current - damage;
            currentLocation = transform.position;
            Instantiate(soundSpawn, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
            if (destroyOnCollision )
            {
                Destroy(this.gameObject);
            }
        }
    }
}
