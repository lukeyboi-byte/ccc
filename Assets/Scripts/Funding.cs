using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Funding : MonoBehaviour
{
<<<<<<< HEAD
    public StatManager statManager;
    public EventManager eventManager;

    public int startingMoney;
    public int currentFunds;
=======
    public int startingMoney;
    public int money;
>>>>>>> parent of c614b1e (getting there)
    public TextMeshProUGUI fundingText;

    private StatHandler stathandler;

    // Start is called before the first frame update
    void Start()
    {
        money = startingMoney;

<<<<<<< HEAD
        fundingText.SetText("$ " + currentFunds.ToString());
    }

    private void OnEnable()
    {
        eventManager.StampApproveEvent += DisplayFunds;
        eventManager.StampDeniedEvent += DisplayFunds;
    }

    private void OnDisable()
    {
        eventManager.StampApproveEvent -= DisplayFunds;
        eventManager.StampDeniedEvent -= DisplayFunds;
    }

    public void DisplayFunds()
    {
        fundingText.SetText("$ " + statManager.calcFunds);
        statManager.decidedScenario = true;
=======
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
        
>>>>>>> parent of c614b1e (getting there)
    }
}
