using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*(Christopher Green)
*(Asteroid.cs)
* (Assignment 3)
* (This scripts contains the basic information about player collision and the destroying of excess asteroids.)
*/
public class Asteroid : MonoBehaviour
{

    private GameController gc;

    private void Awake()
    {
        gc = GameObject.Find("Game Controller").GetComponent<GameController>();
    }

    private void Update()
    {
        StartCoroutine(DestroyAsteroid());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            gc.GameOver();
        }
    }

    IEnumerator DestroyAsteroid()
    {
        yield return new WaitForSeconds(4f);
        Destroy(this.gameObject);
    }
}
