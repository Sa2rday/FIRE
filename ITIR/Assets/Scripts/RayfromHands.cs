using System.Collections;
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
    public LayerMask lM;

    public Unbonding unb;


    public int indexOfSolussion;
    public GameObject playerToDestoroy;
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
               
                if (rayHit.collider.gameObject.GetComponent<Unbonding>())
                {
                    nameg = rayHit.collider.name;
                    unb = rayHit.collider.gameObject.GetComponent<Unbonding>();
                    Unbond();
                   
                }
                else if (rayHit.collider.gameObject.GetComponent<ButtonM>())
                {
                    if(rayHit.collider.gameObject.GetComponent<ButtonM>().indexOfLoadingScences == 0)
                    {
                        LoadScence(0);
                    }else if(rayHit.collider.gameObject.GetComponent<ButtonM>().indexOfLoadingScences == 1)
                    {
                        Application.Quit();
                    }
                   
                }
            }
        }

    }

    void ThrowRay()
    {
        Physics.Raycast(hands[0].transform.position, hands[0].transform.forward, out rayHit,5f,lM);
    }

    void Unbond()
    {
       unb.wasunBonded = false;
       
    }
    public void LoadScence(int i)
    {
        Destroy(playerToDestoroy);
        Application.LoadLevel(i);
    }
 
   
}
