using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*(Christopher Green)
*(Coin.cs)
* (Assignment 3)
* (This scripts handles the basic information and also handles collisions with the player)
*/

public class Coin : MonoBehaviour
{

    public int coinValue;
    public bool collected;
    public int totalCoins;
    public string coinDescription;

    public CoinData coinData;

    void Start()
    { 
        coinData.AddCoin(this);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && !collected)
        {
            this.collected = true;
            CoinTotal.coinValueTotal += this.coinValue;
            Destroy(this.gameObject);
            coinData.NotifyObservers();
        }
    }
}
