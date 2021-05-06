using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Popularity : MonoBehaviour
{
    public StatManager statManager;
    public EventManager eventManager;
    
    public int startingPopularity;
    public int currentPopularity;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        currentPopularity = startingPopularity;
        slider = GetComponent<Slider>();
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
}



