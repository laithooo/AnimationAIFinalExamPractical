using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 5f;
    public Rigidbody rb;
    [SerializeField] private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 moving = new Vector3(horizontal, 0, vertical) * speed;
        rb.AddForce(moving);
        if(vertical != 0 || horizontal != 0)
        {
            animator.SetBool("isWalking", true);

        }

        Vector3 jumping = new Vector3(0, 15, 0)* speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumping);
            animator.SetBool("isJumping", true);
        }

        
    }
}
