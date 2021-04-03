using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public Newspaper newspaper;
    public ScenarioSystem ScenarioSystem;
    public void TriggeredDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

    public void OpenNewspaper()
    {
        
    }

    public void OpenScenario()
    {
        
    }
}
