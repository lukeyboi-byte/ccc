using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScenarioDisplay : MonoBehaviour
{
    public GameObject scenario;
    public DayCycle daycycle;
    public Scenario currentScenario;
    public EventManager eventManager; 
    
    public TextMeshProUGUI headline;
    public TextMeshProUGUI dialogue;
    public TextMeshProUGUI sender;
    public TextMeshProUGUI cost;
    
    public List <Scenario> scenarioObjects;
    public void Start()
    {
        daycycle = FindObjectOfType<DayCycle>();

        if (currentScenario == null)
        {
            return;
        }
    }

    private void OnEnable()
    {
        eventManager.NextDayEvent += CloseScenario;
    }

    private void OnDisable()
    {
        eventManager.NextDayEvent += CloseScenario;
    }

    public void OpenScenario()
    {
        foreach (Scenario s in scenarioObjects)
        {
            if (s.scenarioBranch == daycycle.currentDay)
            {
                if (scenario.activeSelf == false)
                {
                    scenario.SetActive(true);
                }
                else
                {
                    scenario.SetActive(false);
                }

                headline.text = s.scenarioHeadlineText;
                dialogue.text = s.scenarioDialogueText;
                sender.text = s.sender;
                cost.text = s.costText.ToString("$" + cost);

                currentScenario = s;
            }
        }
    }

    public void CloseScenario()
    {
        if (scenario.activeSelf == true)
        {
            scenario.SetActive(false);
        }
    }
    
    
}
