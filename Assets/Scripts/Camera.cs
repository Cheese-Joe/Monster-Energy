using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float offsetSmooth;
    private Vector3 playerPos;

    void Start()
    {
        
    }

    void Update()
    {
        playerPos = new Vector3(player.transform.position.x, player.transform.position.y, -10f);
            
        if(player.transform.localScale.x > 0f)
        {
            playerPos = new Vector3(player.transform.position.x + offset, player.transform.position.y, -10f);
        }
        else
        {
            playerPos = new Vector3(player.transform.position.x - offset, player.transform.position.y, -10f);
        }

        transform.position = Vector3.Lerp(transform.position, playerPos, offsetSmooth * Time.deltaTime);
    }
}
