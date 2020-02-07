using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameController : MonoBehaviour
{

    public float duration;
    public Text timerText;

    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {

        duration = 20;

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

}
