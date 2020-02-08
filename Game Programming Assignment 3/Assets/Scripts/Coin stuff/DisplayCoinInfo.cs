using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
*(Christopher Green)
*(DisplayCoinInfo.cs)
* (Assignment 3)
* (This scripts handles the displaying of information to the screen)
*/

public class DisplayCoinInfo : MonoBehaviour, CoinObserver
{
    public CoinData coinData;

    private string coinInfo;

    void Start()
    {
        this.coinInfo = gameObject.GetComponent<Text>().text;

        coinData.RegisterObserver(this);
    }

    public void UpdateData(List<Coin> coins)
    {
        this.coinInfo = "";
        this.coinInfo += "Total: " + CoinTotal.coinValueTotal.ToString();
        gameObject.GetComponent<Text>().text = this.coinInfo;
    }
}
