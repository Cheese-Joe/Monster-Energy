using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableObjectDatabase : MonoBehaviour
{
    public List<ScriptableObject> objects = new List<ScriptableObject>();
    public static ScriptableObjectDatabase scriptableObjectDatabase;

    private void Awake()
    {

        if(scriptableObjectDatabase == null)
        {
            scriptableObjectDatabase = this;
            DontDestroyOnLoad(this);
            return;
        }

        Destroy(gameObject);

    }
}
