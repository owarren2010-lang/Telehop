using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Teammate : MonoBehaviour
{
    [Header("Reference")]
    public Transform player;

    private NavMeshAgent agent;
    private Animator anim;

    [Header("Follow Settings")]
    public float followDistance = 3f;

    [Header("Combat Settings")]
    public float detectionRange = 10f;
    public float attackRange = 2f;
    public int damage = 20;
    public float attackCooldown = 1.5f;

    private A_I_Copy targetEnemy;
    private float lastAttackTime;

    void Start()
    {
    agent = GetComponent<NavMeshAgent>();
    anim = GetComponent<Animator>();
    }

    
    void Update()
    {
        FindEnemy();
        if (targetEnemy != null)
        {
            FightEnemy();   
        }
        else
        {
         FollowPlayer();
        }
    }

    void FollowPlayer()
    {
        if (player == null)
        {
            return;
        }
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance > followDistance) 
            {
                agent.isStopped = false;
                agent.SetDestination(player.position);

                if (anim != null)
                {
                    anim.SetBool("Walk",true);
                }
                else
                {
                    agent.isStopped = true;
                    anim.SetBool("Walk", false);
                }
            }
            
        
    }
    void FindEnemy()
    {
    if(targetEnemy != null)
        {
        //Remove dead enemy reference
        if(targetEnemy == null)
            {
                targetEnemy = null;
            }
            return;
        }
        Collider[] hits = Physics.OverlapSphere(transform.position, detectionRange);

        float closestDistance = Mathf.Infinity;

        foreach(Collider hit in hits)
        {
            A_I_Copy enemy = hit.GetComponent<A_I_Copy>();

            if (enemy != null)
            {
                float distance = Vector3.Distance(transform.position, enemy.transform.position);

                if(distance <  closestDistance)
                {
                closestDistance = distance;
                targetEnemy = enemy;
                }
            }
         
        }
    }
    void FightEnemy()
    {
        if (targetEnemy == null)
        return; 

        float distance = Vector3.Distance(transform.position, targetEnemy.transform.position);

        //look at enemy
        Vector3 lookDir = (targetEnemy.transform.position - transform.position).normalized;

        lookDir.y = 0;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(lookDir), Time.deltaTime * 8f);

        //Chase enemy
        if (distance > attackRange)
        {
            // Chase
            agent.isStopped = false;
            agent.SetDestination(targetEnemy.transform.position);

            if (anim != null)
                anim.SetBool("Walk", true);
        }
        else
        {
            // Attack
            agent.isStopped = true;

            if (anim != null)
                anim.SetBool("Walk", false);

            if (Time.time > lastAttackTime + attackCooldown)
            {
                lastAttackTime = Time.time;

                if (anim != null)
                    anim.SetTrigger("Punch");

                targetEnemy.Take_Damage(damage);
            }
        }
        //Forget Enemy if too far
        if (distance > detectionRange * 2)
        {
            targetEnemy = null;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);

        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, attackRange);
    }
}
