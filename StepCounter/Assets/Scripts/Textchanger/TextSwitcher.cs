using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSwitcher : MonoBehaviour
{
    public Text talkText;

    private int stepsLeft = 1000;
    private int pedometerSteps;
    public Pedometer pedometer;




    // Start is called before the first frame update
    void Awake()
    {
        GetPedoMeter();
    }

    // Update is called once per frame
    void Update()
    {
        CountstepsLeftDown();
        ChangeText();
    }

    public void GetPedoMeter()
    {
        Pedometer pedometer = GameObject.Find("ScriptManager").GetComponent<Pedometer>();
        
    }

    private void CountstepsLeftDown()
    {
        if(pedometer.amountOfSteps > pedometerSteps)
        {
            pedometerSteps = pedometer.amountOfSteps;
            stepsLeft -= 1;
        }
    }

    private void ChangeText()
    {
        talkText.text = "Nog " + stepsLeft + " stappen over";
    }
}
