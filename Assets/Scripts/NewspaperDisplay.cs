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
    public Popularity popularity;
    
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
        eventManager.NextDayEvent += CloseNewspaper;
    }

    private void OnDisable()
    {
        eventManager.NextDayEvent -= CloseNewspaper;
    }

    public void OpenNewspaper()
    {
        foreach (Newspaper n in newspaperObjects)
        {
            if (n.scenarioBranch == daycycle.currentDay)
            {
                if (popularity.currentPopularity >= 1000)
                {
                    if (n.positive)
                    {
                        ActivateNewspaper(n);
                    }
                }
                else
                {
                    if (n.positive == false)
                    {
                        ActivateNewspaper(n);
                    }
                }
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

    private void ActivateNewspaper(Newspaper n)
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
