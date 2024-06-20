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
    float enemycount = 0;
    float countdown = 0.1f;
    bool fixedcount = false;
    bool onlycontrol = false; // 80‚ð’´‚¦‚½‚©‚Ç‚¤‚©‚Ìƒtƒ‰ƒO

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

        enemycount += Time.deltaTime;

        if (enemycount >= countdown)
        {
            enemycount = 0;
            CountDown();
            if (!fixedcount)
                countdown = Random.Range(0.001f, 0.26f);
        }

        if (count >= 70 && !onlycontrol)
        {
            onlycontrol = true;
            StartCoroutine(FixedCount());
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

    void CountDown()
    {
        count--;
        Count.text = "Count: " + count.ToString();
        if (count <= 0)
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

    IEnumerator FixedCount()
    {
        fixedcount = true;
        countdown = 0.042f;

        yield return new WaitForSeconds(5f);

        fixedcount = false;
    }
}