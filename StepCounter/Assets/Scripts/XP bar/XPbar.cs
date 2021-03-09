using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPbar : MonoBehaviour
{

    private float Progress;
    private int stepPrev;
    private Slider expBar;

    // Update is called once per frame
    void Update()
    {
        expBar = gameObject.GetComponent<Slider>();
        expBar.value = Progress;
        GameObject Importer = GameObject.Find("ScriptManager");
        Pedometer pedometer = Importer.GetComponent<Pedometer>();

        if (pedometer.amountOfSteps > stepPrev)
       {
            Progress += 1;

            stepPrev = pedometer.amountOfSteps;
        }
    }
}
