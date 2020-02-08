
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
*(Christopher Green)
*(ButtonBehavior.cs)
* (Assignment 3)
* (This scripts handles the basic buttons used in the UI menus)
*/

public class ButtonBehavior : MonoBehaviour
{

    public GameObject mainMenu;
    public GameObject gameMenu;
    public GameObject gameoverMenu;

    public bool isInMainMenu;

    public void Start()
    {

    }

    public void Update()
    {

        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            mainMenu.SetActive(true);
            gameMenu.SetActive(false);
            gameoverMenu.SetActive(false);
            isInMainMenu = true;
        }
        else if (SceneManager.GetActiveScene().name == "Game Scene")
        {
            gameMenu.SetActive(true);
            mainMenu.SetActive(false);
            gameoverMenu.SetActive(false);
            isInMainMenu = false;
        }
        else
        {
            gameoverMenu.SetActive(true);
            gameMenu.SetActive(false);
            mainMenu.SetActive(false);
            isInMainMenu = false;
        }
    }

    // General Purpose buttons

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

}