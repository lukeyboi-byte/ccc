using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Newspaper : MonoBehaviour
{
    public GameObject newspaper;

    public void OpenNewspaper()
    {
        Debug.Log("Newspaper opened");
        
        if (newspaper.activeSelf == false)
        {
            newspaper.SetActive(true);
        }
        else
        {
            newspaper.SetActive(false);
        }
    }
}
