using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Funding : MonoBehaviour
{
    public int startingMoney;
    public int money;
    public TextMeshProUGUI fundingText;

    private StatHandler stathandler;

    // Start is called before the first frame update
    void Start()
    {
        money = startingMoney;

        fundingText.SetText("$" + money.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddFunds()
    {
        
    }

    public void TakeFunds()
    {
        
    }
}
