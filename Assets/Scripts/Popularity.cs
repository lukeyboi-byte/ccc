using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Popularity : MonoBehaviour
{
<<<<<<< HEAD
    public StatManager statManager;
    public EventManager eventManager;
    
    public int startingPopularity;
    public int currentPopularity;
=======
    public int startingPopularity;
    public int popularity;
>>>>>>> parent of c614b1e (getting there)
    private Slider slider;

    private StatHandler stathandler;

    // Start is called before the first frame update
    void Start()
    {
        popularity = startingPopularity;
        slider = GetComponent<Slider>();
<<<<<<< HEAD
        slider.value = currentPopularity;
    }

    private void OnEnable()
    {
        eventManager.StampApproveEvent += DisplayPop;
        eventManager.StampDeniedEvent += DisplayPop;
    }

    private void OnDisable()
    {
        eventManager.StampApproveEvent -= DisplayPop;
        eventManager.StampDeniedEvent -= DisplayPop;
    }

    public void DisplayPop()
    {
        slider.value = statManager.calcPop;
        currentPopularity = statManager.calcPop;
        statManager.decidedScenario = true;
    }
=======
        slider.value = popularity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GainPopularity()
    {
        //stathandler.addAmount += GainPopularity();
    }

    public void LosePopularity()
    {
        
    }
    
>>>>>>> parent of c614b1e (getting there)
}



