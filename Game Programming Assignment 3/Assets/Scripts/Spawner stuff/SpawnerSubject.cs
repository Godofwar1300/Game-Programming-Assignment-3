using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*(Christopher Green)
*(SpawnerSubject.cs)
* (Assignment 3)
* (This script is the interface used for the spawner subject implementation.)
*/

public interface SpawnerSubject
{
    void RegisterObserver(SpawnerObserver observer);

    void RemoveObserver(SpawnerObserver observer);

    void NotifyObservers();
}
