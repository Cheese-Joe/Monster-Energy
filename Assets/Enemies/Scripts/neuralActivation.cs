using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;


public class neuralActivation : MonoBehaviour
{
    private Animator animator;
    public GameObject player;
    public float speed;
    public int damage;
    private SpriteRenderer _renderer;
    public HP_system hp;
    public MoneyCount moneyCount;


    void Start()
    {
        animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();

    }


    void Update()
    {
        Debug.Log(player.transform.position);
        if (Vector3.Distance(transform.position, player.transform.position) > 20f)
        {
            animator.SetBool("NeuralActivation", true);
        }
        else
        {
            animator.SetBool("NeuralActivation", false);
            if (transform.position.x - player.transform.position.x < 0)
            {
                transform.Translate(Vector3.right * speed);
                _renderer.flipX = true;
            }
            else if (transform.position.x - player.transform.position.x > 0)
            {
                transform.Translate(Vector3.left * speed);
                _renderer.flipX = false;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "BlueBullet")
        {
            moneyCount.Money = moneyCount.Money + 5;
            Debug.Log("Bullet");
            Destroy(this.gameObject);
        }
        if (collision.transform.tag == "Player")
        {
            hp.HP_current = hp.HP_current - damage;
            Debug.Log("Player");
            Destroy(this.gameObject);
        }
    }
}
