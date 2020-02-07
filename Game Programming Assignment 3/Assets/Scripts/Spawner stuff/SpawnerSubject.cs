using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SpawnerSubject
{
    void RegisterObserver(SpawnerObserver observer);

    void RemoveObserver(SpawnerObserver observer);

    void NotifyObservers();
}
