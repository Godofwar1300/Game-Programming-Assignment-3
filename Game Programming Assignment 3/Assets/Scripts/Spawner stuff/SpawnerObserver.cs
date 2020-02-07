using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface SpawnerObserver
{
    void UpdateData(bool spawning, float force);
}
