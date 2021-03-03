using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPbar : MonoBehaviour
{
    private Slider expBar;
    public float Progress;
   

    // Update is called once per frame
    void Update()
    {
        expBar = gameObject.GetComponent<Slider>();
        expBar.value = Progress;
        GameObject Importer = GameObject.Find("ScriptManager");
        Pedometer pedometer = Importer.GetComponent<Pedometer>();

       if (pedometer.amountOfSteps == pedometer.amountOfSteps++)
        {
            Progress += 1;
        }
    }

}
