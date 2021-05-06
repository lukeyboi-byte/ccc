using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatManager : MonoBehaviour
{
    public ScenarioDisplay scenarioDisplay;
    public Scenario calculateScenario;
    public EventManager eventManager;
    public Funding fundingDisplay;
    public Popularity popularityDisplay;
    
    public int calcFunds;
    public int calcPop;
    public bool decidedScenario;

    public void Start()
    {
        decidedScenario = false;
    }

    private void OnEnable()
    {
        eventManager.NextDayEvent += ApproveNextDayCalc;
        eventManager.NextDayEvent += DeniedNextDayCalc;
        eventManager.StampApproveEvent += ApproveCalculateStats;
        eventManager.StampDeniedEvent += DeniedCalculateStats;
        eventManager.NextDayEvent += ResetDecisionBool;
    }

    private void OnDisable()
    {
        eventManager.NextDayEvent -= ApproveNextDayCalc;
        eventManager.NextDayEvent -= DeniedNextDayCalc;
        eventManager.StampApproveEvent -= ApproveCalculateStats;
        eventManager.StampDeniedEvent -= DeniedCalculateStats;
        eventManager.NextDayEvent -= ResetDecisionBool;
    }

    public void ApproveCalculateStats()
    {
        if (decidedScenario == false)
        {
            calculateScenario = scenarioDisplay.currentScenario;
            calcFunds = fundingDisplay.currentFunds - calculateScenario.costLoss;
            calcPop = popularityDisplay.currentPopularity + calculateScenario.popularityGain;
        }
    }
    public void DeniedCalculateStats()
    {
        if (decidedScenario == false)
        {
            calculateScenario = scenarioDisplay.currentScenario;
            calcFunds = fundingDisplay.currentFunds + calculateScenario.costGain;
            calcPop = popularityDisplay.currentPopularity - calculateScenario.popularityLoss;
        }
    }

    public void ApproveNextDayCalc()
    {
        if (calculateScenario.approved)
        {
            calcFunds = fundingDisplay.currentFunds + calculateScenario.costGain;
            calcPop = popularityDisplay.currentPopularity - calculateScenario.popularityLoss;
            fundingDisplay.DisplayFunds();
            popularityDisplay.DisplayPop();
        }
    }

    public void DeniedNextDayCalc()
    {
        if (calculateScenario.approved == false)
        {
            calcFunds = fundingDisplay.currentFunds - calculateScenario.costLoss;
            calcPop = popularityDisplay.currentPopularity + calculateScenario.popularityGain;
            fundingDisplay.DisplayFunds();
            popularityDisplay.DisplayPop();
        }
    }

    public void ResetDecisionBool()
    {
        decidedScenario = false;
    }
}
