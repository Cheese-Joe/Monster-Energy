using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera2s : MonoBehaviour
{
    public GameObject player;
    public float offset;
    public float offsetSmooth;
    private Vector3 playerPos;
    public GameObject[] Walls;
    public float distanceX;
    public float distance1;
    public float distance2;
    private float XCamera;
    private float YCamera;

    void Start()
    {
        XCamera = transform.position.x;
        YCamera = transform.position.y;
    }

    void Update()
    {
        Walls[0].transform.SetPositionAndRotation(new Vector3(player.transform.position.x, Walls[0].transform.position.y, Walls[0].transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));
        Walls[1].transform.SetPositionAndRotation(new Vector3(player.transform.position.x, Walls[1].transform.position.y, Walls[1].transform.position.z), Quaternion.Euler(new Vector3(0, 0, 0)));


        if ((Vector3.Distance(Walls[2].transform.position, player.transform.position) > distanceX) && (Vector3.Distance(Walls[3].transform.position, player.transform.position) > distanceX))
        {
            if (player.transform.localScale.x > 0f)
            {
                XCamera = player.transform.position.x + offset;
            }
            else
            {
                XCamera = player.transform.position.x - offset;
            }
        }
        if ((Vector3.Distance(Walls[0].transform.position, player.transform.position) > distance1) && (Vector3.Distance(Walls[1].transform.position, player.transform.position) > distance2))
        {
            YCamera = player.transform.position.y;
        }
        playerPos = new Vector3(XCamera, YCamera, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, playerPos, offsetSmooth * Time.deltaTime);
    }
}
