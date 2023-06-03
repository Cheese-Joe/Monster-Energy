using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
    public killCount KillCount;
    private Vector3 currentLocation;
    public GameObject projectile;
    private AudioSource audioSource;
    public AudioClip moveSound;
    public AudioClip hitSound;
    private bool waitWait;
    public TempleData temple;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        _renderer = GetComponent<SpriteRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        if (flying == true)
        {
            rb2d.gravityScale = 0f;
        }
        if (temple.tomfoolery == 6)
        {
            damage = 9999;
        }
    }


    void FixedUpdate()
    {
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
            if (!waitWait)
            {
                StartCoroutine(footsteps());
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == WhichBullet || collision.transform.tag == "Fireball")
        {
            currentLocation = transform.position;
            HP_enemy = HP_enemy - hp.damage;
            audioSource.PlayOneShot(hitSound, 0.3f);
            if (HP_enemy < 1)
            {
                Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
                moneyCount.Money = moneyCount.Money + HowMuchMoney;
                Debug.Log("Bullet");
                KillCount.KillCount = KillCount.KillCount + 1;
                KillCount.score = KillCount.score + 5;
                Destroy(this.gameObject);
            }
        }
        if (collision.transform.tag == "Player")
        {
            Instantiate(projectile, currentLocation, Quaternion.Euler(new Vector3(0, 0, 0)));
            hp.HP_current = hp.HP_current - damage;
            Debug.Log("Player");
            KillCount.KillCount = KillCount.KillCount + 1;
            Destroy(this.gameObject);
        }
    }
    IEnumerator footsteps()
    {
        waitWait = true;
        audioSource.PlayOneShot(moveSound, 0.3f);
        yield return new WaitForSeconds(1f);
        waitWait = false;
    }
}
