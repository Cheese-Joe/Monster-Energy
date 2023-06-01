using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public MoneyCount data;
   public void PLayGame()
    {
        if (data.currentLVL == 0 && !data.gameBeaten)
        {
            SceneManager.LoadScene("Level 0");
        }
        else
            SceneManager.LoadScene("Ship");
    }

    public void PlayBlackjack()
    {
        SceneManager.LoadScene("BlackJack");
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
