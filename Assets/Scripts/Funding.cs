using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Funding : MonoBehaviour
{
    public ScenarioDisplay scenarioDisplay;
    public Scenario calcScenario;
    public int startingMoney;
    public int fundsOutcome;
    public int currentFunds;
    public TextMeshProUGUI fundingText;
    

    // Start is called before the first frame update
    void Start()
    {
        currentFunds = startingMoney;

        fundingText.SetText("$ " + currentFunds.ToString());
        
        if (scenarioDisplay.currentScenario != null)
        {
            calcScenario = scenarioDisplay.currentScenario;
        }
    }

    private void Update()
    {
        throw new NotImplementedException();
    }

    public void InstantFundsOutcome()
    {
        if (calcScenario != null)
        {
            if (calcScenario.instantCostGain)
            {
                fundsOutcome = calcScenario.costGain;
            }

            if (calcScenario.instantPopLoss)
            {
                fundsOutcome = calcScenario.costLoss;
            }
            fundsOutcome += currentFunds;
        }
    }

    public void EndDayFunds()
    {
        if (calcScenario != null)
        {
            if (calcScenario.instantPopGain == false)
            {
                fundsOutcome = calcScenario.costGain;
            }

            if (calcScenario.instantPopLoss == false)
            {
                fundsOutcome = calcScenario.costLoss;
            }
            fundsOutcome += currentFunds;
        }
    }
}
