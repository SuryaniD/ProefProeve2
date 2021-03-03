using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pedometer : MonoBehaviour
{
    public Text steps;

    Gyroscope Gyro;

    float stepDelta = 0.2f;
    bool stepMade = false;
    //Made public for integration with other scripts
    public int amountOfSteps = 0;

    // Start is called before the first frame update
    void Start()
    {
        EnableGyro();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateSteps();
    }

    private void EnableGyro()
    {
        //Get gyro input and enable it
        Gyro = Input.gyro;
        Gyro.enabled = true;
    }

    private void UpdateSteps()
    {
        float movementDetection = Gyro.userAcceleration.z;

        if (!stepMade)
        {
            if (movementDetection >= stepDelta)
            { //Movement up? Start step
                stepMade = true;
            }
        }

        if (stepMade)
        {
            if (movementDetection <= -stepDelta)
            { //Movement down? End step and count
                stepMade = false;
                amountOfSteps++;
                steps.text = amountOfSteps.ToString();
            }
        }
    }
}
