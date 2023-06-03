using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDead : MonoBehaviour
{
    public HP_system hp;

    public string scene;
    public TempleData data;
    
    void Start()
    {
        
    }

    void Update()
    {
        if (hp.HP_current <0)
        {
            hp.HP_current = hp.HP_max;

            if (!data.immortality)
                SceneManager.LoadScene(scene);

        }
    }
}
