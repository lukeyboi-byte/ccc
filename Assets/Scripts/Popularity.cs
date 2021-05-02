using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Popularity : MonoBehaviour
{
    public ScenarioDisplay scenarioDisplay;
    public Scenario calcScenario;
    public int startingPopularity;
    public int popularityOutcome;
    public int currentPopularity;
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        currentPopularity = startingPopularity;
        slider = GetComponent<Slider>();
        slider.value = currentPopularity;

        if (scenarioDisplay.currentScenario != null)
        { 
            calcScenario = scenarioDisplay.currentScenario;
        }
        
    }

    private void Update()
    {
        throw new NotImplementedException();
    }

    public void InstantPopOutcome()
    {
        if (calcScenario != null)
        {
            if (calcScenario.instantPopGain)
            {
                popularityOutcome = calcScenario.popularityGain;
            }

            if (calcScenario.instantPopLoss)
            {
                popularityOutcome = calcScenario.popularityLoss;
            }
            popularityOutcome += currentPopularity;
        }
    }

    public void EndDayPop()
    {
        if (calcScenario != null)
        {
            if (calcScenario.instantPopGain == false)
            {
                popularityOutcome = calcScenario.popularityGain;
            }

            if (calcScenario.instantPopLoss == false)
            {
                popularityOutcome = calcScenario.popularityLoss;
            }
            popularityOutcome += currentPopularity;
        }
    }

}



