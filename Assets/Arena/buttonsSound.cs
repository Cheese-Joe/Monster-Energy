using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class buttonsSound : MonoBehaviour
{
    private Button yourButton;
    public AudioSource audioSource;


    void Awake()
    {
        yourButton = GetComponent<Button>();
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        audioSource.Play();
    }
}
