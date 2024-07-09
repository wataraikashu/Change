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
    public Transform tigerposi;

    int count = 50;
    float enemycount = 0;
    float countdown = 0.25f;
    float speedupcountdown = 0.05f;
    private float move;

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

        if (count >= 1 && count <= 100)
        {
            move = Mathf.Lerp(0, 200f,count/ 100f);
            tigerposi.position = new Vector3(move, tigerposi.position.y, tigerposi.position.z);
        }
    }

    void UpCount()
    {
        Count.text = "Count: " + count.ToString();
        count++;
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