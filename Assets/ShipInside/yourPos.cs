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
    public SceneAsset scene;
    private bool checkCollision;
    public ShipData ship;
    public Vector3 pos;


    void Update()
    {
        if (checkCollision)
        {
            counterText.text = text;
            if (Input.GetKeyDown(KeyCode.E))
            {
                ship.position = pos;
                SceneManager.LoadScene(scene.name);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
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
