
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
    public GameObject winMenu;
    public GameObject instructionsMenu;

    //public bool isInMainMenu;

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
            winMenu.SetActive(false);
            instructionsMenu.SetActive(false);
            // isInMainMenu = true;
        }
        else if (SceneManager.GetActiveScene().name == "Game")
        {
            gameMenu.SetActive(true);
            mainMenu.SetActive(false);
            gameoverMenu.SetActive(false);
            winMenu.SetActive(false);
            instructionsMenu.SetActive(false);
            //   isInMainMenu = false;
        }
        else if (SceneManager.GetActiveScene().name == "Game Over")
        {
            gameoverMenu.SetActive(true);
            gameMenu.SetActive(false);
            mainMenu.SetActive(false);
            winMenu.SetActive(false);
            instructionsMenu.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "Win")
        {
            winMenu.SetActive(true);
            gameoverMenu.SetActive(false);
            gameMenu.SetActive(false);
            mainMenu.SetActive(false);
            instructionsMenu.SetActive(false);
           // isInMainMenu = false;
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

    public void Instructions()
    {
        SceneManager.LoadScene(4);
    }

    public void InstructionsBack()
    {
        SceneManager.LoadScene(0);
    }

}