using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class A_I_Copy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;
    private Animator animator;
    public Transform[] patrolPoints;
    private int currentPatrolIndex;

    public float chaseRange = 10f;
    public float attackRange = 2f;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        foreach(var dd in patrolPoints)
        {
        dd.parent = null;
        }
    }
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, player.position);
        if (distanceToTarget < attackRange)
        {
            agent.SetDestination(transform.position);
            animator.SetBool("Walk", false);
            animator.SetBool("Swipe", true);
            animator.applyRootMotion = true;
        }

        else if(distanceToTarget <= chaseRange)
        {
            agent.SetDestination(player.position);
            animator.SetBool("Walk", true);
            animator.SetBool("Swipe", false);
            animator.applyRootMotion = false;

        }

        else
        {
            animator.SetBool("Walk", true);
            animator.SetBool("Swipe", false);
            patrol();
        }
    }
    void patrol()
    {
        if (patrolPoints.Length == 0)
        {
        return;
        }

        if (agent.remainingDistance < agent.stoppingDistance)
        {
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
            agent.SetDestination(patrolPoints[currentPatrolIndex].position);
        }
    }   
    public int EnemyHealth = 100;
    public Slider EnemyHP;
    
    public void Take_Damage(int damage)
    {
        EnemyHealth -= damage;
        EnemyHP.value = EnemyHealth;
        if(EnemyHealth <= 0)
        {
            animator.SetBool("Defeated", true);
            animator.SetBool("Idle", false);
            animator.SetBool("Walk", false);
            animator.SetBool("Swipe", false);
            animator.applyRootMotion = true;
            agent.enabled = false;
            this.enabled = false;
           EnemyHP.gameObject.SetActive(false);            
           GameObject.Find("Respawn Point").GetComponent<EnemyReviver>().OnEnemyDied();
           Destroy(gameObject);
            
        }
    }
}
