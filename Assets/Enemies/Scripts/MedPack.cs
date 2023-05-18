using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MedPack : MonoBehaviour
{
    public int heal;
    public HP_system hp;
    // Start is called before the first frame update
    void Start()
    {
        transform.DORotate(new Vector3(0, 360, 0), 1f, RotateMode.LocalAxisAdd).SetLoops(-1, LoopType.Incremental);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            if (hp.HP_current < hp.HP_max)
            {
                hp.HP_current = hp.HP_current + heal;
                if (hp.HP_current > hp.HP_max)
                {
                    hp.HP_current = hp.HP_max;
                }
                Debug.Log("Player");
                Destroy(this.gameObject);
            }
        }
    }
}
