using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara3 : MonoBehaviour
{

    public Animator animator;
    public float start = 0f;
    public bool dance = false;

    void Start()
    {

    }

    void Update()
    {
        if (!dance)
        {
            start += Time.deltaTime;
            if (start >= 3.5f)
            {
                animator.SetTrigger("dance1");
                dance = true;
            }
        }
    }
}
