using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    public event Action NextDayEvent;
    public event Action StampApproveEvent;
    public event Action StampDeniedEvent;

    public void OnNextDayEnter()
    {
        NextDayEvent?.Invoke();
    }

    public void OnStampApprove()
    {
        StampApproveEvent?.Invoke();
    }

    public void OnStampDenied()
    {
        StampDeniedEvent?.Invoke();
    }
}
