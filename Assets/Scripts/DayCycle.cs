using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    /// <summary>
    /// 1. start day with opening newspaper with a reaction to scenario choices next day (first day will have the same paper for now maybe welcoming the mayor to office)
    /// 2. calculate funding and popularity
    /// 3. change scenario
    /// 4. player has to approve or deny a scenario
    /// 5. immediate funding calculation after choice
    /// 6. end day
    /// </summary>
    ///
    public EventManager eventManager;
    public int day = 1;

    public void OnEnable()
    {
        eventManager.OnNextDayEvent += NextDay;
    }

    public void OnDisable()
    {
        eventManager.OnNextDayEvent -= NextDay;
    }

    public void NextDay()
    {
        day++;
    }
}
