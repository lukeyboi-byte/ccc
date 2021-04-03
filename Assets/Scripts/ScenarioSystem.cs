using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScenarioSystem : MonoBehaviour
{
    public GameObject scenario;

    public void OpenScenario()
    {
        if (scenario.activeSelf == false)
        {
            scenario.SetActive(true);
        }
        else
        {
            scenario.SetActive(false);
        }
        
    }
}
