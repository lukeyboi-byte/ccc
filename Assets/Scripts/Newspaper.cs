using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Newspaper : MonoBehaviour
{
    public DialogueManager dialogueManager;
    public DayCycle dayCycle;

    public event Action OpenNewspaper;
    void Start()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        throw new NotImplementedException();
    }

    public void OnOpenNewspaper()
    {
        OpenNewspaper?.Invoke();
    }
}
