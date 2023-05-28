using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class getToLVL : MonoBehaviour
{
    public Button yourButton;
    public SceneAsset[] scene;
    public MoneyCount data;

    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        SceneManager.LoadScene(scene[data.LVL].name);
    }

}
