using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healing_Coins : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        GetComponent<PlayerHealth>().Health(20);
        
    }

}
