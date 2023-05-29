using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Quit : MonoBehaviour
{
    public Button yourButton;
    public GameObject buttonStart;
    public cardData CC;
    public killCount KillCount;


    void Awake()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        if (KillCount.highScore <= CC.score)
        {
            KillCount.highScore = CC.score;
        }
        CC.score = 0;
        SceneManager.LoadScene("Ship");
    }
}
