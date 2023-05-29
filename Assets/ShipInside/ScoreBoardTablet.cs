using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreBoardTablet : MonoBehaviour
{
    public ShipData ship;
    public Vector3[] pos;
    public GameObject showButtons;
    public MoneyCount money;



    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            showButtons.SetActive(true);
            if (money.gameBeaten)
            {
                ship.position = pos[1];
            }
            else
            {
                ship.position = pos[0];
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            showButtons.SetActive(false);
        }
    }
}
