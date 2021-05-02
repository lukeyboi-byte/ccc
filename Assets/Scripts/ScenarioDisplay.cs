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
    public EventManager eventManager;
    public Scenario currentScenario;
    
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
    
    public void OnEnable()
    {
        eventManager.OnNextDayEvent += CloseScenario;
    }

    public void OnDisable()
    {
        eventManager.OnNextDayEvent -= CloseScenario;
    }

    public void OpenScenario()
    {
        foreach (Scenario s in scenarioObjects)
        {
            if (s.scenarioBranch == daycycle.day)
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
