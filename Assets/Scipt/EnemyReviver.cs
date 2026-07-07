using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReviver : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float respawnTime = 3.0f;
    private bool isDead = false;
    private float timer = 0f;

    // Call this from the enemy script when it dies
    public void OnEnemyDied()
    {
        isDead = true;
        timer = 0f;
    }

    void Update()
    {
        if (isDead)
        {
            timer += Time.deltaTime;
            if (timer >= respawnTime)
            {
                Instantiate(enemyPrefab, transform.position, Quaternion.identity);
                isDead = false;
                timer = 0f;
            }
        }
    }
}
