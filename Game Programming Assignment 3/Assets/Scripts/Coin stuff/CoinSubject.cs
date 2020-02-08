using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*(Christopher Green)
*(CoinSubject.cs)
* (Assignment 3)
* (This script is the interface used for the coin subject implementation.)
*/

public interface CoinSubject
{
    void RegisterObserver(CoinObserver observer);
    void RemoveObserver(CoinObserver observer);
    void NotifyObservers();
}
