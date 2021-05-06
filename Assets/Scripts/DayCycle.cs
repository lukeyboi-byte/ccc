using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayCycle : MonoBehaviour
{
<<<<<<< HEAD
    public EventManager eventManager;
    public int currentDay = 1;

    public void OnEnable()
    {
        eventManager.NextDayEvent += NextDay;
=======
    //We will manage the day cycle here which will create events for scripts that need to know when to apply there functions
    public event Action NextDay;
    
    public int day = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
>>>>>>> parent of c614b1e (getting there)
    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        eventManager.NextDayEvent -= NextDay;
=======
        
>>>>>>> parent of c614b1e (getting there)
    }

    public void OnNextDay()
    {
<<<<<<< HEAD
        currentDay++;
=======
        day++;
        NextDay?.Invoke();
>>>>>>> parent of c614b1e (getting there)
    }
}
