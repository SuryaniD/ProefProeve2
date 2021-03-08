using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextSwitcher : MonoBehaviour
{
    public Text talkText;

    //Needs to be changed to the value of the trophy
    private int stepsLeft = 1000;

    //The imported steps form the pedometer script
    private int pedometerSteps;

    bool stepsText = true;


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
        StartCoroutine(TextTimer());

        //Works with boolean
        if(stepsText == true) 
        { 
            talkText.text = "Nog " + stepsLeft + " stappen over"; 
        }
        if(stepsText == false)
        {
            talkText.text = "Ga zo door!";
        }

        IEnumerator TextTimer()
        { 
            //Switch from boolean every 5 seconds
            if(stepsText == true)
            {
                yield return new WaitForSeconds(5f);
                stepsText = false;
            }
            if(stepsText == false)
            {
                yield return new WaitForSeconds(5f);
                stepsText = true;
            }
        }

    }

}
