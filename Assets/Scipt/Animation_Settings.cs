using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation_Settings : MonoBehaviour
{
    public Animator playeranimator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playeranimator.SetBool("WalkBack",true);
            playeranimator.SetBool("MoonWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            playeranimator.SetBool("MoonWalking", true);
            playeranimator.SetBool("WalkBack", false);
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
        playeranimator.SetBool("WalkBack", false);
            playeranimator.SetBool("MoonWalking", false);
        }    
       
    }
}
