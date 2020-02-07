using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour, SpawnerObserver
{

    public bool spawning;
    float force;

    public SpawnerData spawnerData;

    public GameObject asteroid;



    public void UpdateData(bool spawning, float force)
    {
        if (this.spawning != spawning)
        {
            this.spawning = spawning;
            UpdateSpawning();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        spawnerData.RegisterObserver(this);
    }

    void UpdateSpawning()
    {
        if (spawning)
        {
            InvokeRepeating("SpawnAsteroids", .5f, 2.0f);
        }
        else
        {
            CancelInvoke();
        }
    }

    void SpawnAsteroids()
    {
        Instantiate(asteroid, transform.position, transform.rotation);
    }
}
