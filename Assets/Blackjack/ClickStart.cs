using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class ClickStart : MonoBehaviour
{
    public Button yourButton;
    public GameObject buttonStart;
    public AudioSource audioSource;
    public AudioClip audioClip;
    public cardData CC;
    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        CC.audioContinue = audioSource.time;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
