using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinData : MonoBehaviour, CoinSubject
{

    List<CoinObserver> observers = new List<CoinObserver>();

    private bool collected = false;
    private int coinTotal = 0;

    public void RegisterObserver(CoinObserver observer)
    {

        observers.Add(observer);

        observer.UpdateData(collected);
        //observer.UpdateData(coinTotal);
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
            observer.UpdateData(collected);
            //observer.UpdateData(coinTotal);
            Debug.Log("Observers were notified.");
        }
    }
}
