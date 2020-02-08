using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/*
*(Christopher Green)
*(GameController.cs)
* (Assignment 3)
* (This scripts handles the basic game elements like the timer and game over condition)
*/

public class GameController : MonoBehaviour
{

    public float duration;
    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {

        duration = 60;

        while (duration > 0)
        {
            duration -= Time.deltaTime;
            timerText.text = "Timer: " + duration.ToString("00");
            yield return null;
        }

        if(duration <= 0)
        {
            GameOver();
        }
    }
    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void WinGame()
    {
        SceneManager.LoadScene(3);
    }

}
