using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game3Fadeout : MonoBehaviour
{

    public float alpha = 0f;
    public float fadespeed = 1f;
    public float maxAlpha = 0.5f;
    public float second = 0;
    public GameObject Line;



    private Material fadeMaterial;

    void Start()
    {
        fadeMaterial = GetComponent<Renderer>().material;
        Color color = fadeMaterial.color;
        color.a = alpha;
        fadeMaterial.color = color;

        Line.SetActive(false);
    }

    void Update()
    {
      second += Time.deltaTime;
        if (second >= 3)
        {
            alpha = Mathf.Clamp(alpha + fadespeed * Time.deltaTime, 0f, maxAlpha);
            Color color = fadeMaterial.color;
            color.a = alpha;
            fadeMaterial.color = color;
        }

        if (second >= 5)
        {
            Line.SetActive(true);
        }
    }
}