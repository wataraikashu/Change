using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float down = 30;

    public Text text;

    void Update()
    {
        down -= Time.deltaTime;

        text.text = down.ToString("F1");

        if (down <= 0)
        {
            Chara.NextScene();
        }
    }
}
