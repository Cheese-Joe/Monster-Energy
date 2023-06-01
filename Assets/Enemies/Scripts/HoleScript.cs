using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public HP_system hp;
    public GameObject player;
    public Vector3 checkpointPos;
    public int damage;
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
            player.transform.position = checkpointPos;
        }
    }
}
