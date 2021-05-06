using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Newspaper : MonoBehaviour
{
    public GameObject newspaper;

<<<<<<< HEAD
     public int scenarioBranch;
     public bool positive;
=======
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
>>>>>>> parent of c614b1e (getting there)
}
