using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, CoinObserver
{

    public int coinValue;
    //public int coinTotal;
    bool collected;

    private static int coinTotal;

    public CoinData coinData;

    private GameController gc;


    // Start is called before the first frame update
    void Start()
    {
        coinData.RegisterObserver(this);
        gc = GameObject.Find("Game Controller").GetComponent<GameController>();
    }

    void Update()
    {
        Debug.Log("The coint total is: " + coinTotal);
        Debug.Log("Collecrted is: " + collected);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player") && !collected)
        {
            collected = true;
            coinTotal ++;
            Debug.Log("The coint total, on impact, is: " + coinTotal);
            Debug.Log("Collecrted, on impact, is: " + collected);
            collected = true;
            gc.scoreText.text = "Score: " + coinTotal;
            Destroy(this.gameObject);
            coinData.NotifyObservers();
        }
    }

    public void UpdateData(bool collected)
    {
        this.collected = collected;
    }

    //public void UpdateData(int coinTotal)
    //{
    //    this.coinTotal = coinTotal;
    //}
}
