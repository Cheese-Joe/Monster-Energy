using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
   public void PLayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
