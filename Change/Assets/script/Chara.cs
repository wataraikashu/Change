using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{
    new Rigidbody rigidbody;
    Animator animator;
    bool pickup = false;
    float pickcontlol = 1.2f; 
    float pickTime = 0f; 

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        pick();
        if (!pickup)
        {
            move();
        }
        else
        {
            animator.SetBool("Run", false); 
        }
    }

    void move()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }

        if (moveDirection != Vector3.zero)
        {
            transform.position += moveDirection.normalized * 0.002f;
            transform.rotation = Quaternion.LookRotation(moveDirection);
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }

    void pick()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Pickup", true);
            pickup = true;
            pickTime = Time.time + pickcontlol; 
        }


        if (pickup && Time.time >= pickTime)
        {
            animator.SetBool("Pickup", false);
            pickup = false;
        }
    }
}