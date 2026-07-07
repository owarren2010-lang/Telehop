using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMapScript : MonoBehaviour
{
    public Transform player;
    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        if (!player) return;
        transform.position = new Vector3( player.position.x, transform.position.y, player.position.z);
    }
}
