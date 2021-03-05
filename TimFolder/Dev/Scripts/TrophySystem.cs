using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophySystem : MonoBehaviour
{
    //Object in game thats in the screen (getting used for this xyz)
    public GameObject m11Trophyxyz;
    public GameObject m12Trophyxyz;
    public GameObject m13Trophyxyz;

    //Asset in foldermenu
    public GameObject m11TrophyAsset;
    public GameObject m12TrophyAsset;
    public GameObject m13TrophyAsset;

    
    //
    public int StepCounter = 0;
    private int M1Points = 0;

    //bool which MissionSerie is on
    private bool Mission1 = true;
   // private bool Mission2 = false;
   // private bool Mission3 = false;

    //Bool which Mission from the MissionSerie is on
    private bool LockM11 = false;
    private bool LockM12 = false;
    private bool LockM13 = false;

    void Start()
    {
        m11Trophyxyz = GameObject.FindGameObjectWithTag("m11Trophyxyz");
        m12Trophyxyz = GameObject.FindGameObjectWithTag("m12Trophyxyz");
        m13Trophyxyz = GameObject.FindGameObjectWithTag("m13Trophyxyz");
    }

    
    void Update()
    {
        if (Mission1 == true)
        {
            if (StepCounter >= 3000 && LockM11 == false)
            {
                LockM11 = true;
                Instantiate(m11TrophyAsset, m11Trophyxyz.transform.position, Quaternion.identity);
                M1Points++;         
            }

            if (StepCounter >= 2000 && LockM12 == false)
            {
                LockM12 = true;
                Instantiate(m12TrophyAsset, m12Trophyxyz.transform.position, Quaternion.identity);
                M1Points++;
            }

            if (StepCounter >= 1000 && LockM13 == false)
            {
                LockM13 = true;
                Instantiate(m13TrophyAsset, m13Trophyxyz.transform.position, Quaternion.identity);
                M1Points++;
            }

            //Set MissionSerie to 2
            if (M1Points >= 3)
            {
                Mission1 = false;
               // Mission2 = true;
            }
        }


        //Mission2
    }
}
