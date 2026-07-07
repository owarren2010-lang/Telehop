using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSystem : MonoBehaviour
{
    public GameObject coinPrefab;
    public float spawnRadius = 5f;
    public void CoinPosition()
    {
        Vector3 randomOffset = new Vector3(
            Random.Range(-spawnRadius, spawnRadius),
            0f,
            Random.Range(-spawnRadius, spawnRadius)
        );

        Vector3 spawnPosition = transform.position + randomOffset;

        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}
