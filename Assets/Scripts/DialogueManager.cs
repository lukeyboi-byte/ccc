using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI newspaperHeadlinesText;
    public TextMeshProUGUI newspaperExcerptText;
    public TextMeshProUGUI scenarioHeadlineText;
    public TextMeshProUGUI scenarioExcerptText;
    
    private Queue<string> newspaperHeadlines;
    private Queue<string> newspaperExcerpts;
    private Queue<string> scenarioHeadlines;
    private Queue<string> scenarioExcerpts;

    void Start()
    {
        newspaperHeadlines = new Queue<string>();
        newspaperExcerpts = new Queue<string>();
        scenarioHeadlines = new Queue<string>();
        scenarioExcerpts = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue)
    {
        newspaperHeadlines.Clear();
        newspaperExcerpts.Clear();
        scenarioHeadlines.Clear();
        scenarioExcerpts.Clear();

        foreach (string newspaperHeadline in dialogue.headlines)
        {
            newspaperHeadlines.Enqueue(newspaperHeadline);
        }
        
        foreach (string newspaperExcerpt in dialogue.excerpts)
        {
            newspaperExcerpts.Enqueue(newspaperExcerpt);
        }

        foreach (string scenarioHeadline in dialogue.headlines)
        {
            scenarioHeadlines.Enqueue(scenarioHeadline);
        }

        foreach (string scenarioExcerpt in dialogue.excerpts)
        {
            scenarioExcerpts.Enqueue(scenarioExcerpt);
        }

        NextDayDialogue();
    }
    
    public void NextDayDialogue()
    {
        //Newspapers
        if (newspaperHeadlines.Count == 0 && newspaperExcerpts.Count == 0)
        {
            EndDialogue();
            return;
        }

        string newspaperHeadline = newspaperHeadlines.Dequeue();
        newspaperHeadlinesText.text = newspaperHeadline;

        string newspaperExcerpt = newspaperExcerpts.Dequeue();
        newspaperExcerptText.text = newspaperExcerpt;
        
        //Scenarios
        if (scenarioHeadlines.Count == 0 && scenarioExcerpts.Count == 0)
        {
            EndDialogue();
            return;
        }

        string scenarioHeadline = scenarioHeadlines.Dequeue();
        scenarioHeadlineText.text = scenarioHeadline;
        
        string scenarioExcerpt = scenarioExcerpts.Dequeue();
        scenarioExcerptText.text = scenarioExcerpt;

    }

    void EndDialogue()
    {
        Debug.Log("End of Dialogue.");
    }
}
