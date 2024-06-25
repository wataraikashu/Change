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
    float countdown = 0.25f;
    float speedupcountdown = 0.05f;

    void Start()
    {
        animator = GetComponent<Animator>();
        currentState = State.Akey;
        UpCount();
        StartCoroutine(CountDownSpeed());
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
        }
    }

    void UpCount()
    {
        Count.text = "Count: " + count.ToString();
        count++;    
        if(count >= 100)
        {
            //‘ŠŽè‚ÌTransform‚ð“®‚©‚µ‚½‚¢
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

    IEnumerator CountDownSpeed()
    {
        if (animator == null)
        {
            yield break;
        }

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2,4));
            countdown = speedupcountdown;
            yield return new WaitForSeconds(Random.Range(2.5f, 4));
            countdown = 0.25f;
        }
    }

    IEnumerator falsebutton()
    {
        Button.SetActive(false);

        yield return new WaitForSeconds(0.11f);

        Button.SetActive(true);
    }


}