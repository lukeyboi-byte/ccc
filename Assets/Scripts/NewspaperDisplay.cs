using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NewspaperDisplay : MonoBehaviour
{
    public GameObject newspaper;
    public DayCycle daycycle;
    public EventManager eventManager;
    
    public TextMeshProUGUI companyName;
    public TextMeshProUGUI headline;
    public TextMeshProUGUI dialogue;

    public List <Newspaper> newspaperObjects;

    public void Start()
    {
        daycycle = FindObjectOfType<DayCycle>();
    }

    private void OnEnable()
    {
        eventManager.OnNextDayEvent += CloseNewspaper;
    }

    private void OnDisable()
    {
        eventManager.OnNextDayEvent -= CloseNewspaper;
    }

    public void OpenNewspaper()
    {
        foreach (Newspaper n in newspaperObjects)
        {
            if (n.scenarioBranch == daycycle.day)
            {
                if (newspaper.activeSelf == false)
                {
                    newspaper.SetActive(true);
                }
                else
                {
                    newspaper.SetActive(false);
                }

                companyName.text = n.newspaperCompany;
                headline.text = n.newspaperHeadlineText;
                dialogue.text = n.newspaperDialogueText;
            }
        }
    }
    
    public void CloseNewspaper()
    {
        if (newspaper.activeSelf == true)
        {
            newspaper.SetActive(false);
        }
    }
}
