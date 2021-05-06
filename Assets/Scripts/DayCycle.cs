using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    public EventManager eventManager;
    public int currentDay = 1;

    public void OnEnable()
    {
        eventManager.NextDayEvent += NextDay;
    }

    public void OnDisable()
    {
        eventManager.NextDayEvent -= NextDay;
    }

    public void NextDay()
    {
        currentDay++;
    }
}
