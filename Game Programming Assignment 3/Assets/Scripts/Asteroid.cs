using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    private GameController gc;

    public bool canDie;

    private void Awake()
    {
        gc = GameObject.Find("Game Controller").GetComponent<GameController>();
        canDie = true;
    }

    private void Update()
    {
        StartCoroutine(DestroyAsteroid());
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && canDie)
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
