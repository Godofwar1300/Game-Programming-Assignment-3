using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CoinSubject
{
    void RegisterObserver(CoinObserver observer);
    void RemoveObserver(CoinObserver observer);
    void NotifyObservers();
}
