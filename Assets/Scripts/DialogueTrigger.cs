using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public NewspaperDisplay newspaperDisplay;
    public ScenarioDisplay scenarioDisplay;
    public EventManager eventManager;

    public void OpenNewspaper()
    {
        newspaperDisplay.OpenNewspaper();
    }

    public void OpenScenario()
    {
        scenarioDisplay.OpenScenario();
    }
}
