using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public event Action OnNextDayEvent;
    
    public void NextDayEnter()
    {
        if (OnNextDayEvent != null)
        {
            OnNextDayEvent();
        }
    }
}
