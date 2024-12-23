using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clear : MonoBehaviour
{
    public Text percentText1;
    public Text percentText2;
    public Text percentText3;

    void Start()
    {
        int st1 = Chara.st1;
        int st2 = CountDown.st2;
        int st3 = Chara3.st3;

        if (st1 == 1 && st2 == 1 && st3 == 1)
        {
            percentText1.text = "100%";
            percentText2.text = "100%";
            percentText3.text = "100%";
        }
        else
        {
            percentText1.text = call(st1);
            percentText2.text = call(st2);
            percentText3.text = call(st3);
        }
    }

    string call(int st)
    {
        switch (st)
        {
            case 1:
                return "30%";
            case 2:
                return "60%";
            case 3:
                return "100%";
            default:
                return "0%";
        }
    }
}