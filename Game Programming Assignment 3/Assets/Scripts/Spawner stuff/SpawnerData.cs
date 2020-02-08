using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
*(Christopher Green)
*(SpawnerData.cs)
* (Assignment 3)
* (This acts as the subject for the spawner with its implementation of the interface)
*/

public class SpawnerData : MonoBehaviour, SpawnerSubject
{
    List<SpawnerObserver> observers = new List<SpawnerObserver>();

    private bool spawning = true;
    private float force = 50f;

    public void RegisterObserver(SpawnerObserver observer)
    {
        observers.Add(observer);

        observer.UpdateData(spawning, force);
    }

    public void RemoveObserver(SpawnerObserver observer)
    {
        if(observers.Contains(observer))
        {
            observers.Remove(observer);
        }
    }

    public void NotifyObservers()
    {
        foreach(SpawnerObserver observer in observers)
        {
            observer.UpdateData(spawning, force);
            Debug.Log("UpdateData was called from Notify Observers");
        }
    }
}
