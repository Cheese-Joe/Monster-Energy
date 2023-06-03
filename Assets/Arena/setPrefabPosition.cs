using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setPrefabPosition : MonoBehaviour
{
    public GameObject prefab;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        prefab.transform.SetPositionAndRotation(player.transform.position, player.transform.rotation);
    }
}
