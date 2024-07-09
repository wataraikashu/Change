using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{

    [SerializeField]
    private Selectable firstSelected = null;


    void Start()
    {
        firstSelected.Select();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("game1");
    }

    public void LoadNextScene2()
    {
        SceneManager.LoadScene("game2");
    }
}
