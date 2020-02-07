/*
*(Christopher Green)
*(ButtonBehavior.cs)
* (Assignment 2)
* (This scripts handles the basic buttons used in the UI menus)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{

    //public GameObject pauseMenu;
    public GameObject mainMenu;
    public GameObject gameMenu;
    public GameObject gameoverMenu;
    public GameObject resultsMenu;

    private Text star1Text;
    private Text star2Text;
    private Text star3Text;

    public GameObject star1;
    public GameObject star2;
    public GameObject star3;

    public Button starButton1;
    public Button starButton2;
    public Button starButton3;

    bool canPause;
    bool isInMainMenu;

    public void Awake()
    {
        star1Text = GameObject.Find("Canvas").transform.GetChild(4).GetChild(2).GetComponent<Text>();
        star2Text = GameObject.Find("Canvas").transform.GetChild(4).GetChild(3).GetComponent<Text>();
        star3Text = GameObject.Find("Canvas").transform.GetChild(4).GetChild(4).GetComponent<Text>();
    }

    public void Start()
    {
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }

    public void Update()
    {

        if (SceneManager.GetActiveScene().name == "Main Menu")
        {
            mainMenu.SetActive(true);
            gameMenu.SetActive(false);
            gameoverMenu.SetActive(false);
            resultsMenu.SetActive(false);
            isInMainMenu = true;
            canPause = false;
        }
        else if (SceneManager.GetActiveScene().name == "Game Scene")
        {
            gameMenu.SetActive(true);
            mainMenu.SetActive(false);
            gameoverMenu.SetActive(false);
            resultsMenu.SetActive(false);
            isInMainMenu = false;
            canPause = true;
        }
        else if (SceneManager.GetActiveScene().name == "Rating Scene")
        {
            resultsMenu.SetActive(true);
            gameMenu.SetActive(false);
            mainMenu.SetActive(false);
            isInMainMenu = false;
            canPause = false;
        }
        else
        {
            gameoverMenu.SetActive(true);
            resultsMenu.SetActive(false);
            gameMenu.SetActive(false);
            mainMenu.SetActive(false);
            isInMainMenu = false;
            canPause = false;
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

    // Results menu buttons

    public void StarOne()
    {
        starButton1.interactable = false;
        starButton2.interactable = false;
        starButton3.interactable = false;
        StartCoroutine(GameOver());
        star1.SetActive(true);
        //star1Text.text = "Aww, really? Here's 50 points for your troubles"
    }

    public void StarTwo()
    {
        starButton1.interactable = false;
        starButton2.interactable = false;
        starButton3.interactable = false;
        StartCoroutine(GameOver());
        star2.SetActive(true);
        //star2Text.text = "Getting Better! Here's 150 points for your troubles";
    }

    public void StarThree()
    {
        starButton1.interactable = false;
        starButton2.interactable = false;
        starButton3.interactable = false;
        StartCoroutine(GameOver());
        star3.SetActive(true);
        //star3Text.text = "Fantstic! Here's 200 points for your masterpiece";
    }

    IEnumerator GameOver()
    {
        yield return new WaitForSeconds(5);
        SceneManager.LoadScene(3);
    }

}