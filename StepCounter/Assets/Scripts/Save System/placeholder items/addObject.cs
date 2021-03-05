using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class addObject : MonoBehaviour
{
    public GameObject spawn;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(spawn, new Vector2(0, 0), Quaternion.identity);

        }
    }
}
