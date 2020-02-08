using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
*(Christopher Green)
*(SpawnerObserver.cs)
* (Assignment 3)
* (This script is the interface used for the spawner observer implementation.)
*/

public interface SpawnerObserver
{
    void UpdateData(bool spawning, float force);
}
