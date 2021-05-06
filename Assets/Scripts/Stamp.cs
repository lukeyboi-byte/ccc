using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamp : MonoBehaviour
{
    public EventManager eventManager;
    public Collider2D scenarioStampCol;
    public ScenarioDisplay scenarioDisplay;
    public Scenario collidedScenario;

    public bool approved;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == scenarioStampCol)
        {
            collidedScenario = scenarioDisplay.currentScenario;

            if (approved)
            {
                eventManager.OnStampApprove();
                collidedScenario.approved = true;
            }

            if (approved == false)
            {
                eventManager.OnStampDenied();
                collidedScenario.approved = false;
            }
        }
    }
}
