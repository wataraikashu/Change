using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float down = 30;

    public Text text;

    public GameObject basecharacter;
    public bool endposi = false;
    public Vector3 posi;

    public GameObject textoff;
    public GameObject button1off;
    public GameObject button2off;


    void Start()
    {
        posi = new Vector3(-80f, -90f, 140f);
        basecharacter.transform.position = posi;

    }


    void Update()
    {
        down -= Time.deltaTime;

        text.text = down.ToString("F1");

        if (down <= 0)
        {
            endposi = true;
        }

        if (endposi)
        {
            if (posi.x > -200f)
            {
                textoff.SetActive(false);
                button1off.SetActive(false);
                button2off.SetActive(false);
                posi.x -= 0.5f;
                basecharacter.transform.position = posi;

            }
            else
            {
                Chara.NextScene();
            }
        }
    }
}
