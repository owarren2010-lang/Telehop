using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Apple;

public class A_I : MonoBehaviour
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
    }

    // Update is called once per frame
    void Update()
    {
        float distanceToTarget = Vector3.Distance(transform.position, player.position);
        if (distanceToTarget <= attackRange)
        {
            agent.SetDestination(transform.position);
         //   animator.SetBool("Walk", false);
          //  animator.SetBool("Attack", true);
          //  animator.applyRootMotion = true;
        }

        else if (distanceToTarget <= chaseRange)
        {
            agent.SetDestination(player.position);
          //  animator.SetBool("Walk", true);
          //  animator.SetBool("Attack", false);
          //  animator.applyRootMotion = false;
        }
        else
        {
         //   animator.SetBool("Walk", true);
          //  animator.SetBool("Attack", false);
         //   animator.SetBool("Idle", false);
            patrol();
        }
        void patrol()
        {
        if(patrolPoints.Length == 0)
            {
                return;
            }
            if (agent.remainingDistance < agent.stoppingDistance) 
            { 
                currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
                agent.SetDestination(patrolPoints[currentPatrolIndex].position);
            }
        }

    }
}
