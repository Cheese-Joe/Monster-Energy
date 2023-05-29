using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLVL : MonoBehaviour
{
    public GameObject player;
    public int waitWait;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {

            player.GetComponent<Rigidbody2D>().gravityScale = 0f;
            player.GetComponent<Jump>().enabled = false;
            player.GetComponent<Movement>().enabled = false;
            player.GetComponent<shootingNormal>().enabled = false;

            if (waitWait == 0)
            {
                StartCoroutine(movePlayer());
            }

        }
        IEnumerator movePlayer()
        {
            waitWait = 1;
            player.transform.DOMoveY(5, 4f).SetRelative(true).SetLoops(1, LoopType.Incremental);
            yield return new WaitForSeconds(4f);
            SceneManager.LoadScene("GameWon");
        }

    }
}
