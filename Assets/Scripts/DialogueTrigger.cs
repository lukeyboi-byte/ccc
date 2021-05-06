using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
<<<<<<< HEAD
    public NewspaperDisplay newspaperDisplay;
    public ScenarioDisplay scenarioDisplay;
=======
    public Dialogue dialogue;
    public Newspaper newspaper;
    public ScenarioSystem scenarioSystem;
    public void TriggeredDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }
>>>>>>> parent of c614b1e (getting there)

    public void OpenNewspaper()
    {
        newspaper.OpenNewspaper();
    }

    public void OpenScenario()
    {
        scenarioSystem.OpenScenario();
    }
}
