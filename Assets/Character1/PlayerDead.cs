using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    public HP_system hp;

    public SceneAsset scene;
    public TempleData data;
    public Transform dzCheck;
    public LayerMask dzLayer;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (hp.HP_current <0)
        {
            hp.HP_current = hp.HP_max;

            if (!data.immortality)
                SceneManager.LoadScene(scene.name);

        }
        else if(Physics2D.OverlapCapsule(dzCheck.position, new Vector2(0.14f, 0.07f), CapsuleDirection2D.Horizontal, 0, dzLayer))
        {
            if (!data.immortality)
                SceneManager.LoadScene(scene.name);
        }
    }
}
