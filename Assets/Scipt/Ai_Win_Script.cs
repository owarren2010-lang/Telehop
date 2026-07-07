using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai_Win_Script : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
        Destroy(collision.gameObject);
        }
    }
}
