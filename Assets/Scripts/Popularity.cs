using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class Popularity : MonoBehaviour
{
    public int startingPopularity;
    public int popularity;
    private Slider slider;

    private StatHandler stathandler;

    // Start is called before the first frame update
    void Start()
    {
        popularity = startingPopularity;
        slider = GetComponent<Slider>();
        slider.value = popularity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GainPopularity()
    {
        //stathandler.addAmount += GainPopularity();
    }

    public void LosePopularity()
    {
        
    }
    
}



