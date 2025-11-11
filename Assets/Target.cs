using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform targetDestination;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        animator.SetBool("isRunning", true);

        if (agent != null && targetDestination != null)
        {

            agent.SetDestination(targetDestination.position);
        }


    }

    void OnCollideEnter(Collider collider)
    {
        if (collider.CompareTag("Target"))
        {
            animator.SetBool("isRunning", false);
            Debug.Log("Player in sights, attack!");
        }
    }
}
