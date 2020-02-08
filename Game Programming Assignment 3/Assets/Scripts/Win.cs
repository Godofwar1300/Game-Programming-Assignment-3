using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
*(Christopher Green)
*(Win.cs)
* (Assignment 3)
* (This scripts handles the win state of the game)
*/

public class Win : MonoBehaviour
{

    GameController gc;
    //public Text needMorePoints;
    public GameObject needMorePointsObj;

    private void Awake()
    {
        gc = GameObject.Find("Game Controller").GetComponent<GameController>();
    }

    private void Start()
    {
        needMorePointsObj.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if(CoinTotal.coinValueTotal < 500)
            {
                needMorePointsObj.SetActive(true);
            }
            else
            {
                gc.WinGame();
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            needMorePointsObj.SetActive(false);
        }
    }
}
