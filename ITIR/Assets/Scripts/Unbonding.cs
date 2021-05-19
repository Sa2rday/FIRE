using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;


public class Unbonding : MonoBehaviour
{
    public PartsOption partsOption;
    public bool wasunBonded;
    
    void Start()
    {
        wasunBonded = true;
        
    }

   
    void Update()
    {
        if(wasunBonded == false && partsOption.wasBonded == true)
        {
            partsOption.pointsConnector[0] = false;
            partsOption.pointsConnector[1] = false;
            wasunBonded = true;
        }
    }
}
