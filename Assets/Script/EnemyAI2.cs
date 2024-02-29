using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI2 : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float chaseRange = 10;

    NavMeshAgent navMeshAgent;
    float distanceToTarget = Mathf.Infinity;
    [SerializeField] float turnSpeed = 5f;
    public PlayerHealth playerHealth;
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }




    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (distanceToTarget <= chaseRange && playerHealth.currentHealth > 0)
        {
            EngageTarget();
        }
        if (playerHealth.currentHealth == 0)
        {
            gameOver();
        }
    }

    private void gameOver()
    {
        enemyGameOver();
        playerHealth.PlayerDeath();
    }

    private void enemyGameOver()
    {
        navMeshAgent.ResetPath();
        GetComponent<Animator>().SetBool("Attack", false);
        GetComponent<Animator>().ResetTrigger("Move");
    }

    private void EngageTarget()
    {
        FaceTarget();
        if (distanceToTarget >= navMeshAgent.stoppingDistance)
        {
            ChaseTarget();
        }

        if (distanceToTarget <= navMeshAgent.stoppingDistance)
        {
            AttackTarget();
        }
    }

    private void AttackTarget()
    {
        GetComponent<Animator>().SetBool("Attack", true);
    }

    private void ChaseTarget()
    {
        GetComponent<Animator>().SetBool("Attack", false);
        GetComponent<Animator>().SetTrigger("Move");
        navMeshAgent.SetDestination(target.position);
    }

    private void FaceTarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * turnSpeed);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, chaseRange);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(1);
        }
    }
}
