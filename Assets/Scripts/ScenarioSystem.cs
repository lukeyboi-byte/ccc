using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScenarioSystem : MonoBehaviour
{
    //Here we will have to organise lists of newspaper entries and scenarios adn print them out at their necessary timing
    public DialogueManager dialogueManager;
    public DayCycle dayCycle;
    
    public event Action OpenScenario;

    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void OnOpenScenario()
    {
        OpenScenario?.Invoke();
    }
}
