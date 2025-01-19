using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y : MonoBehaviour
{
    public float yziku;
    void Start()
    {
        yziku = transform.position.y;
    }

    void LateUpdate()
    {
        transform.position = new Vector3(transform.position.x, yziku, transform.position.z);
    }
}
