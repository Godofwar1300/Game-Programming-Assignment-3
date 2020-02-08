using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*(Christopher Green)
*(CoinData.cs)
* (Assignment 3)
* (This acts as the subject for the coins with its implementation of the interface)
*/

public class CoinData : MonoBehaviour, CoinSubject
{

    private List<CoinObserver> observers = new List<CoinObserver>();

    public List<Coin> coins = new List<Coin>();

    public void RegisterObserver(CoinObserver observer)
    {
        observers.Add(observer);

        if (coins != null)
        {
            observer.UpdateData(coins);
        }
    }

    public void RemoveObserver(CoinObserver observer)
    {
        if (observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }
    public void NotifyObservers()
    {
        foreach (CoinObserver observer in observers)
        {
            observer.UpdateData(coins);
            Debug.Log("Observers were notified.");
        }
    }

    public void AddCoin(Coin coin)
    {
        coins.Add(coin);
        NotifyObservers();
    }
}