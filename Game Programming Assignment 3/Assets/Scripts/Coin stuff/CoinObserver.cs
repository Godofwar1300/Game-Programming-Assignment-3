using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface CoinObserver 
{
    void UpdateData(bool collected);
    //void UpdateData(int coinTotal);
}
