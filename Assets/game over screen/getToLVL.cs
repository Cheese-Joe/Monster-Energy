using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class getToLVL : MonoBehaviour
{
    public Button yourButton;
    public string[] scene;
    public MoneyCount data;
    public bool goToLVLSelect;

    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (!goToLVLSelect)
        {
            SceneManager.LoadScene(scene[data.currentLVL]);
        }
        else
        {
            if (!data.gameBeaten)
            {
                SceneManager.LoadScene(scene[data.currentLVL]);
            }
            else
            {
                SceneManager.LoadScene("LVLSelect");
            }
        }
    }

}
