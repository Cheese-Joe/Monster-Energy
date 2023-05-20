using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public Transform groundCheck;
    public LayerMask groundLayer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics2D.OverlapCapsule(groundCheck.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, groundLayer))
            Destroy(gameObject);
    }
}
