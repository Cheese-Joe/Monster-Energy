using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class SetLVLtoSelected : MonoBehaviour
{
    public Button yourButton;
    public MoneyCount data;
    public int selectedLVL;

    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        data.currentLVL = selectedLVL;
    }
}
