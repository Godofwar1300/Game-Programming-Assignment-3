using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*(Christopher Green)
*(CoinObserver.cs)
* (Assignment 3)
* (This script is the interface used for the coin observer implementation.)
*/

public interface CoinObserver 
{
    void UpdateData(List<Coin> coins);
}
