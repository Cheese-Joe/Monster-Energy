using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathAnim : MonoBehaviour
{
    Animator anim;
    public int health = 0;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame


    void Update()
    {
        if (health <= 0)
        {
            Dead();
        }
    }

    void Dead()
    {
        anim.SetTrigger("DeathAnim");
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
