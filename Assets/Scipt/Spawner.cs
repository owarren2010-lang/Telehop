using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject coinPrefab;

    private void Start()
    {
    Instantiate(coinPrefab,transform.position,coinPrefab.transform.rotation);
    
    }


}
