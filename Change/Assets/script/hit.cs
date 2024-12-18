using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hit : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    public Animator animator;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;
    public Animator animator4;

    public GameObject gameobject;
    public GameObject gameobject1;
    public GameObject gameobject2;
    public float speed = 1.6f;
    public float end = 2f;
    public float second = 0;
    public string notetag = "note";
    public float radius = 0.5f;

    public int count = 0;

    void Start()
    {
        startposition(gameobject);
        startposition(gameobject1);
        startposition(gameobject2);

        circleCollider = GetComponent<CircleCollider2D>();
    }
        void Update()
        {

            second += Time.deltaTime;

        Moveobject(gameobject);
        Moveobject(gameobject1);
        Moveobject(gameobject2);

        if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("a");
                RaycastHit2D hit = Physics2D.CircleCast(transform.position, radius, Vector2.zero);

                if (hit.collider != null && hit.collider.CompareTag(notetag))
                {
                    Debug.Log("ab");
                    float distance = Mathf.Abs(hit.transform.position.x - transform.position.x);
                if (distance < 0.1f)
                {
                    Debug.Log("parfect");
                    animator.Play("per1", 0, 0f);
                }
                else if (distance < 0.3f)
                {
                    Debug.Log("good");
                    animator1.Play("good1", 0, 0f);
                }
                else if (distance < 0.6f)
                {
                    Debug.Log("normal");
                    animator2.Play("normal1", 0, 0f);
                }
                else
                {
                    Debug.Log("not");
                    animator3.Play("not1", 0, 0f);
                    count++;
                    if (count >= 3)
                    {
                        SceneManager.LoadScene("Title");
                    }

                }
                    Destroy(hit.collider.gameObject);
                }
            }
        }

    void Moveobject(GameObject obj)
    {
        if (obj != null)
        {
            obj.transform.Translate(speed * Time.deltaTime, 0, 0);
            if (obj.transform.position.x >= end)
            {
                Debug.Log("miss");
                animator4.Play("miss1", 0, 0f);
                gameovercount();

                Destroy(obj);
            }
        }

       
    }
    void startposition(GameObject obj)
        {
            if (obj != null)
            {
                obj.transform.position = new Vector3(obj.transform.position.x, obj.transform.position.y, obj.transform.position.z);
            }
        }

    void gameovercount()
    {
        count++;
        if (count >= 3)
        {
            SceneManager.LoadScene("Title");
        }
    }
}