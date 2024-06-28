using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    public float speed = 1;

    void Start()
    {

    }

    void Update()
    {
                transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
