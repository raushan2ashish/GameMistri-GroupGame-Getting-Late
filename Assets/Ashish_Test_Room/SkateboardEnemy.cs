using UnityEngine;

public class SkateboardEnemy : MonoBehaviour
{
    public float detectionRange = 10f;
    public float attackRange = 2f;
    public float moveSpeed = 5f;
    public Transform player;

    //private Animator animator;
    private enum State { Idle, Alert, Attack }
    private State currentState = State.Idle;

    void Start()
    {
      //  animator = GetComponent<Animator>();
    }

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        switch (currentState)
        {
            case State.Idle:
                Patrol();
                if (distanceToPlayer < detectionRange)
                {
                    currentState = State.Alert;
                }
                break;

            case State.Alert:
                ChasePlayer();
                if (distanceToPlayer < attackRange)
                {
                    currentState = State.Attack;
                }
                break;

            case State.Attack:
                AttackPlayer();
                break;
        }
    }

    void Patrol()
    {
        // Code for patrolling behavior
        //animator.SetBool("isMoving", true);
    }

    void ChasePlayer()
    {
        // Code for chasing the player
        transform.position = Vector3.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime);
        //animator.SetBool("isMoving", true);
    }

    void AttackPlayer()
    {
        // Code for attacking the player
        //animator.SetTrigger("attack");
    }
}
