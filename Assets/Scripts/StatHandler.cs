using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatHandler : MonoBehaviour
{
    //here we will have the events reusable for both popularity and funding

    public Action<int> addAmount;
    public Action<int> takeAmount;

    void AddAmount(int amount)
    {
        addAmount?.Invoke(amount);
    }

    void TakeAmount(int amount)
    {
        takeAmount?.Invoke(amount);
    }
}
