using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara : MonoBehaviour
{

    new Rigidbody rigidbody;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        int Run = Animator.StringToHash("Run");

        rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        move(); 
    }

    void move()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Run", true);
        }
        else 
        {
            animator.SetBool("Run", false);
        }


        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(0.002f, 0, 0);
            Rotation(0, 90, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-0.002f, 0, 0);
            Rotation(0, -90, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0, 0.002f);
            Rotation(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, 0, -0.002f);
            Rotation(0, -180, 0);
        }
    }

    void Rotation(float x, float y, float z)
    {
        transform.rotation = Quaternion.Euler(x, y, z);
    }

}