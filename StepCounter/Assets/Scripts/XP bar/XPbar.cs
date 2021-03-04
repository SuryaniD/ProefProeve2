using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPbar : MonoBehaviour
{
    //slider itself
    private Slider expBar;

    //the number of steps taken put into the xp bar
    public float Progress;
    private int prevStepCount;

    // Update is called once per frame
    void Update()
    {
        expBar = gameObject.GetComponent<Slider>();
        expBar.value = Progress;
        GameObject Importer = GameObject.Find("ScriptManager");
        Pedometer pedometer = Importer.GetComponent<Pedometer>();

        //if a value is added to amountOfSteps, 1 is added to Progress
    

        if (pedometer.amountOfSteps > prevStepCount) {​​​​​​​​
        Progress += 1;

        prevStepCount = pedometer.amountOfSteps;
            }​​​​​​     ​​
        }​​​​​​​​


        }
    


