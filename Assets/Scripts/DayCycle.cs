using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
    //We will manage the day cycle here which will create events for scripts that need to know when to apply there functions
    public event Action NextDay;
    
    public int day = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNextDay()
    {
        day++;
        NextDay?.Invoke();
    }
}
