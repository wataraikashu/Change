using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Chara2 : MonoBehaviour
{
    Animator animator;
    enum State
    {
        Akey, Dkey
    }
    State currentState;
    public Text Count;
    public GameObject Button;

    int count = 50;

    void Start()
    {
        animator = GetComponent<Animator>();
        currentState = State.Akey;
        UpCount();
    }

    void Update()
    {
        switch (currentState)
        {
            case State.Akey:
                if (Input.GetKeyDown(KeyCode.A))
                {
                    currentState = State.Dkey;
                    UpCount();
                    StartCoroutine(falsebutton());
                }
                break;

            case State.Dkey:
                if (Input.GetKeyDown(KeyCode.D))
                {
                    currentState = State.Akey;
                    UpCount();
                    StartCoroutine(falsebutton());
                }
                break;
        }
    }

    void UpCount()
    {
        Count.text = "Count: " + count.ToString();
        count++;    
        if(count >= 100)
        {
            SceneManager.LoadScene("Title");
        }
    }

    IEnumerator falsebutton()
    {
        Button.SetActive(false);

        yield return new WaitForSeconds(0.11f);

        Button.SetActive(true);
    }


}