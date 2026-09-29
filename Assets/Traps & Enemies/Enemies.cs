using System;
using UnityEngine;
using UnityEngine.UI;

public class Enemies : MonoBehaviour
{
    [SerializeField] private Slider Healthbar;
    private float health = 100f;
    public Transform player;

    [Header("Movement")]
    public float speed = 3f;
    public float detectionRange = 5f;

    [Header("Patrol Points")]
    public Transform pointA;
    public Transform pointB;

    private Transform currentPatrolPoints;
    CircleCollider2D cb;
    void Start()
    {
        currentPatrolPoints = pointA;
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);

        if (distanceToPlayer <= detectionRange)
        {
            MoveTo(player.position);
        }
        else
        {
            MoveTo(currentPatrolPoints.position);

            if (Vector2.Distance(transform.position, currentPatrolPoints.position) < 0.1f)
            {
                SwitchPatrolPoint();
            }
        }
    }

    void MoveTo(Vector2 target)
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
    void SwitchPatrolPoint()
    {
        if (currentPatrolPoints == pointA)
            currentPatrolPoints = pointB;
        else
            currentPatrolPoints = pointA;


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindAnyObjectByType<Health>().TakeDamage(1);
    }

    public void UpdateHealthBar(int damage)
    {
        health -= damage;
        Healthbar.value = health;
        if (health < 0)
        {
            Destroy(gameObject);
        }
    }

    private void Awake()
    {
        cb = GetComponent<CircleCollider2D>();
    }

}
