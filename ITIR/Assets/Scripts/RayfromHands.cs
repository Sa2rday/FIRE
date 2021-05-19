﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class RayfromHands : MonoBehaviour
{
    public GameObject[] hands;
    public RaycastHit rayHit;
    public SteamVR_Action_Boolean actBool;
    public string nameg;
    LineRenderer lR;
    void Start()
    {
        lR = GetComponent<LineRenderer>();
    }

    
    void Update()
    {
        lR.SetPosition(0, hands[0].transform.position);
        lR.SetPosition(1, hands[1].transform.position);
        
        Debug.DrawRay(hands[0].transform.position, hands[0].transform.forward * 5);
        if (actBool.stateDown)
        {
            ThrowRay();
            if (rayHit.collider != null)
            {
                nameg = rayHit.collider.name;
                if (rayHit.collider.gameObject.GetComponent<Unbonding>())
                {
                    Unbond();
                }
            }
        }

    }

    void ThrowRay()
    {
        Physics.Raycast(hands[0].transform.position, hands[0].transform.forward * 5, out rayHit);
    }

    void Unbond()
    {
        rayHit.collider.gameObject.GetComponent<Unbonding>().bonding.bonding.partsOption.pointsConnector[0] = false;
        rayHit.collider.gameObject.GetComponent<Unbonding>().bonding.bonding.partsOption.pointsConnector[1] = false;
    }
 
   
}
