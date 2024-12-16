using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    public CircleCollider2D circleCollider;
    public Animator animator;
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;

    public GameObject gameobject;
    public float speed = 1.6f;
    public float start = -3f;
    public float end = 1f;
    public float second = 0;
    public string notetag = "note";
    public float radius = 0.5f;

    public bool perfectnotes = false;
    public bool goodnotes = false;
    public bool normalnotes = false;
    public bool notnotes = false;

    void Start()
    {
        if (gameobject != null)
        {
            gameobject.transform.position = new Vector3(start, gameobject.transform.position.y, gameobject.transform.position.z);

        }
        circleCollider = GetComponent<CircleCollider2D>();
    }
        void Update()
        {

            second += Time.deltaTime;
            if (second >= 2.5f)
            {
                if (gameobject != null)
                {
                    gameobject.transform.Translate(speed * Time.deltaTime, 0, 0);
                    if (gameobject.transform.position.x >= end)
                    {
                        Destroy(gameobject);
                    }
                }
            }

            if (Input.GetKeyDown(KeyCode.A))
            {
                Debug.Log("a");
                RaycastHit2D hit = Physics2D.CircleCast(transform.position, radius, Vector2.zero);

                if (hit.collider != null && hit.collider.CompareTag(notetag))
                {
                    Debug.Log("ab");
                    float distance = Mathf.Abs(hit.transform.position.x - transform.position.x);
                if (distance < 0.075f && !perfectnotes)
                {
                    Debug.Log("parfect");
                    animator.SetTrigger("perfect");
                    perfectnotes = true;
                }
                else if (distance < 0.3f && !goodnotes)
                {
                    Debug.Log("good");
                    animator1.SetTrigger("good");
                    goodnotes = true;
                }
                else if (distance < 0.6f && !normalnotes)
                {
                    Debug.Log("normal");
                    animator2.SetTrigger("normal");
                    normalnotes = true;
                }
                else if (!notnotes)
                {
                    Debug.Log("not");
                    animator3.SetTrigger("not");
                    notnotes = true;

                }
                    Destroy(hit.collider.gameObject);
                }
            }
        }

        void onGizmos()
        {
            if (circleCollider != null)
            {
                Gizmos.color = Color.red;
                Gizmos.DrawWireSphere(transform.position, radius);
            }
        }
}