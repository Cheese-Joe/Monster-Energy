using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public MoneyCount data;
   public void PLayGame()
    {
        SceneManager.LoadScene("Level 0");
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
    public void PLayGameShip()
    {
        SceneManager.LoadScene("Ship");

    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
}
