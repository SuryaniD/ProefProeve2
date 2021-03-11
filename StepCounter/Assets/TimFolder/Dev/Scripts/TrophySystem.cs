using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophySystem : MonoBehaviour
{
    //what this script does
    //Counter is on specific number (1000, 2000, 3000) trophy unlocked spawns in shelf, gives bool when shelf full
    
    
    //Object in game thats in the screen (getting used for this xyz (is an invis object)
    public GameObject m11Trophyxyz;
    public GameObject m12Trophyxyz;
    public GameObject m13Trophyxyz;

    public GameObject m21Trophyxyz;
    public GameObject m22Trophyxyz;
    public GameObject m23Trophyxyz;

    public GameObject m31Trophyxyz;
    public GameObject m32Trophyxyz;
    public GameObject m33Trophyxyz;

    //Asset in foldermenu
    public GameObject m11TrophyAsset;
    public GameObject m12TrophyAsset;
    public GameObject m13TrophyAsset;

    public GameObject m21TrophyAsset;
    public GameObject m22TrophyAsset;
    public GameObject m23TrophyAsset;

    public GameObject m31TrophyAsset;
    public GameObject m32TrophyAsset;
    public GameObject m33TrophyAsset;


    //
    public int StepCounter = 0;
    private int M1Points = 0;
    private int M2Points = 0;
    private int M3Points = 0;

    //bool which MissionSerie is on
    private bool Mission1 = true;
    private bool Mission2 = false;
    private bool Mission3 = false;

    //Bool which Mission from the MissionSerie is on (clicked the button)(set it to false to activate(true = lockedstate)
    private bool LockM11 = true;
    private bool LockM12 = true;
    private bool LockM13 = true;

    private bool LockM21 = true;
    private bool LockM22 = true;
    private bool LockM23 = true;

    private bool LockM31 = true;
    private bool LockM32 = true;
    private bool LockM33 = true;

    //End of the game bool (everything is done shelf is full)
    public bool EndOfTheGame = false;

    void Start()
    {
        //Finds the invis object with tag will be used later for x.y.z values
        m11Trophyxyz = GameObject.FindGameObjectWithTag("m11Trophyxyz");
        m12Trophyxyz = GameObject.FindGameObjectWithTag("m12Trophyxyz");
        m13Trophyxyz = GameObject.FindGameObjectWithTag("m13Trophyxyz");
    }

    
    void Update()
    {
        //takes the amount of steps from pedometer script and sets it in this script as (int) Stepcounter
        StepCounter = gameObject.GetComponent<Pedometer>().amountOfSteps;

        //Mission1
        if (Mission1 == true)
        {
            if (StepCounter >= 3000 && LockM11 == false)
            {
                LockM11 = true;
                M1Points++;         
            }

            if (StepCounter >= 2000 && LockM12 == false)
            {
                LockM12 = true;
                M1Points++;
            }

            if (StepCounter >= 1000 && LockM13 == false)
            {
                LockM13 = true;
                M1Points++;
            }

            //Set MissionSerie to 2
            if (M1Points >= 3)
            {
                Mission1 = false;
                Mission2 = true;
            }
        }


        //Mission2

        if (Mission2 == true)
        {
            if (StepCounter >= 3000 && LockM21 == false)
            {
                LockM21 = true;
                M2Points++;
            }

            if (StepCounter >= 2000 && LockM22 == false)
            {
                LockM22 = true;
                M2Points++;
            }

            if (StepCounter >= 1000 && LockM23 == false)
            {
                LockM13 = true;
                M2Points++;
            }

            //Set MissionSerie to 3
            if (M2Points >= 3)
            {
                Mission2 = false;
                Mission3 = true;
            }
        }

        //Mission3

        if (Mission3 == true)
        {
            if (StepCounter >= 3000 && LockM31 == false)
            {
                LockM31 = true;
                M3Points++;
            }

            if (StepCounter >= 2000 && LockM32 == false)
            {
                LockM32 = true;
                M3Points++;
            }

            if (StepCounter >= 1000 && LockM33 == false)
            {
                LockM33 = true;
                M3Points++;
            }

            //Stops last mission serie
            if (M3Points >= 3)
            {
                Mission3 = false;
                EndOfTheGame = true;
            }
        }





        //Instantiate the Throphys
        //Is now outside of the script above to easily change the code if the save system has to be done differently

        //1
        if (LockM11 == true)
        {
            Instantiate(m11TrophyAsset, m11Trophyxyz.transform.position, Quaternion.identity);
        }
        if (LockM12 == true)
        {
            Instantiate(m12TrophyAsset, m12Trophyxyz.transform.position, Quaternion.identity);
        }
        if (LockM13 == true)
        {
            Instantiate(m12TrophyAsset, m13Trophyxyz.transform.position, Quaternion.identity);
        }
        //2
        if (LockM21 == true)
        {
            Instantiate(m21TrophyAsset, m21Trophyxyz.transform.position, Quaternion.identity);
        }
        if (LockM22 == true)
        {
            Instantiate(m22TrophyAsset, m22Trophyxyz.transform.position, Quaternion.identity);
        }
        if (LockM23 == true)
        {
            Instantiate(m22TrophyAsset, m23Trophyxyz.transform.position, Quaternion.identity);
        }
        //3
        if (LockM31 == true)
        {
            Instantiate(m31TrophyAsset, m31Trophyxyz.transform.position, Quaternion.identity);
        }
        if (LockM32 == true)
        {
            Instantiate(m32TrophyAsset, m32Trophyxyz.transform.position, Quaternion.identity);
        }
        if (LockM33 == true)
        {
            Instantiate(m32TrophyAsset, m33Trophyxyz.transform.position, Quaternion.identity);
        }

    }
}
