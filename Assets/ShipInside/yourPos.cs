using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yourPos : MonoBehaviour
{
    public TMP_Text counterText;
    public string text;
    private bool checkCollision;
    public ShipData ship;
    public Vector3 pos;
    public string scene;


    void Update()
    {
        if (checkCollision)
        {
            counterText.text = text;
            if (Input.GetKeyDown(KeyCode.E))
            {
                SceneManager.LoadScene(scene);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            ship.position = pos;
            checkCollision = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            counterText.text = "";
            checkCollision = false;
        }
    }
}
