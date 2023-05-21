using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.FilePathAttribute;


public class neuralActivation : MonoBehaviour
{
    private Animator animator;
    public GameObject player;
    public float speed;
    public float speedY;
    public int damage;
    private SpriteRenderer _renderer;
    public HP_system hp;
    public MoneyCount moneyCount;
    public int HowMuchMoney;
    public bool flying;
    private Rigidbody2D rb2d;
    public string WhichBullet;
    public int HP_enemy;
    void Start()
    {
        animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        if (flying == true)
        {
            rb2d.gravityScale = 0f;
        }
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
            if (transform.position.x - player.transform.position.x < -1f)
            {
                transform.Translate(Vector3.right * speed);
                _renderer.flipX = true;
            }
            else if (transform.position.x - player.transform.position.x > 1f)
            {
                transform.Translate(Vector3.left * speed);
                _renderer.flipX = false;
            }
            if (transform.position.y - player.transform.position.y < -1f)
            {
                transform.Translate(Vector3.up * speedY);
            }
            else if (transform.position.y - player.transform.position.y > 1f)
            {
                transform.Translate(Vector3.down * speedY);
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == WhichBullet)
        {
            HP_enemy = HP_enemy - hp.damage;
            if (HP_enemy < 1)
            {
                moneyCount.Money = moneyCount.Money + HowMuchMoney;
                Debug.Log("Bullet");
                Destroy(this.gameObject);
            }
        }
        if (collision.transform.tag == "Player")
        {
            hp.HP_current = hp.HP_current - damage;
            Debug.Log("Player");
            Destroy(this.gameObject);
        }
    }
}
