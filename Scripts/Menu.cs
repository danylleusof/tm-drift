using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject how2Play;
    public GameObject credits;

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void How2PlayGame()
    {
        mainMenu.gameObject.SetActive(false);
        how2Play.gameObject.SetActive(true);
    }

    public void GameCredits()
    {
        mainMenu.gameObject.SetActive(false);
        credits.gameObject.SetActive(true);
    }

    public void Return()
    {
        mainMenu.gameObject.SetActive(true);
        how2Play.gameObject.SetActive(false);
        credits.gameObject.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log ("Quit :(");
        Application.Quit();
    }
}
