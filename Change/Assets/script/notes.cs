using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notes : MonoBehaviour
{

    public float speed = 2f;
    public float start = -3.85f;
    public float end = 1.5f;
    public float second = 0;

    void Start()
    {
        transform.position = new Vector3(start, transform.position.y, transform.position.z);
    }

    void Update()
    {
        second += Time.deltaTime;
        if (second >= 6)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
    }
}
