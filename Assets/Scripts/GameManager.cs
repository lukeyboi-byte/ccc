using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject newspaperView;
    public GameObject scenarioView;
    
    // Start is called before the first frame update
    void Start()
    {
        newspaperView.SetActive(false);
        scenarioView.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
