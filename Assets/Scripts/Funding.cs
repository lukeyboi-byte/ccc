using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Funding : MonoBehaviour
{
    public StatManager statManager;
    public EventManager eventManager;

    public int startingMoney;
    public int currentFunds;
    public TextMeshProUGUI fundingText;
    

    // Start is called before the first frame update
    void Start()
    {
        currentFunds = startingMoney;

        fundingText.SetText("$ " + currentFunds.ToString());
    }

    private void OnEnable()
    {
        eventManager.StampApproveEvent += DisplayFunds;
        eventManager.StampDeniedEvent += DisplayFunds;
    }

    private void OnDisable()
    {
        eventManager.StampApproveEvent -= DisplayFunds;
        eventManager.StampDeniedEvent -= DisplayFunds;
    }

    public void DisplayFunds()
    {
        fundingText.SetText("$ " + statManager.calcFunds);
        statManager.decidedScenario = true;
    }
}
