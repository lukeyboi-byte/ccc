using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "New Scenario", menuName = "Scenario")]
public class Scenario : ScriptableObject
{
    [TextArea(1,3)]
    public string scenarioHeadlineText;
    [TextArea(15,20)]
    public string scenarioDialogueText;
    [TextArea(1,3)]
    public string sender;
    public int scenarioBranch;
    public int costText;

    public int costGain;
    public int costLoss;
    public int popularityGain;
    public int popularityLoss;

    public bool approved = false;
}