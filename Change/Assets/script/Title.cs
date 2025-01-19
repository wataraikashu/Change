using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Title : MonoBehaviour
{

    [SerializeField]
    private Selectable firstSelected = null;

    public static int scenecount = 0;

    public GameObject Object1;
    public GameObject Object2;


    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        firstSelected.Select();
        countobj1();
        countobj2();
        scenecount = PlayerPrefs.GetInt("scenecount", 0);

    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene("game1");
    }

    public void LoadNextScene2()
    {
        SceneManager.LoadScene("game2");
    }

    public void LoadNextScene3()
    {
        SceneManager.LoadScene("game3");
    }

    private void countobj1()
    {
        if (Object1 != null)
        {
            if (scenecount == 1)
            {
                Object1.SetActive(true);
            }
            else
            {
                Object1.SetActive(false);
            }
        }
    }

    private void countobj2()
    {
        if (Object2 != null)
        {
            if (scenecount == 2)
            {
                Object2.SetActive(true);
            }
            else
            {
                Object2.SetActive(false);
            }
        }
    }
}
