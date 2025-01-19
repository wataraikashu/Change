using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
    public GameObject gameobject3;
    public GameObject gameobject4;
    public GameObject gameobject5;
    public GameObject gameobject6;
    public GameObject gameobject7;
    public GameObject gameobject8;
    public GameObject gameobject9;
    public GameObject gameobject10;
    public GameObject gameobject11;
    public GameObject gameobject12;
    public GameObject gameobject13;
    public GameObject gameobject14;
    public GameObject gameobject15;
    public GameObject gameobject16;
    public GameObject gameobject17;
    public GameObject gameobject18;
    public GameObject gameobject19;
    public GameObject gameobject20;
    public GameObject gameobject21;
    public GameObject gameobject22;
    public GameObject gameobject23;
    public GameObject gameobject24;
    public GameObject gameobject25;
    public GameObject gameobject26;
    public GameObject gameobject27;
    public GameObject gameobject28;
    public GameObject gameobject29;
    public GameObject gameobject30;
    public GameObject gameobject31;
    public GameObject gameobject32;
    public GameObject gameobject33;
    public GameObject gameobject34;
    public GameObject gameobject35;
    public GameObject gameobject36;
    public GameObject gameobject37;
    public GameObject gameobject38;
    public GameObject gameobject39;
    public GameObject gameobject40;
    public GameObject gameobject41;
    public GameObject gameobject42;
    public GameObject gameobject43;
    public GameObject gameobject44;
    public GameObject gameobject45;
    public GameObject gameobject46;
    public GameObject gameobject47;
    public GameObject gameobject48;
    public GameObject gameobject49;
    public GameObject gameobject50;
    public float speed = 1.6f;
    public float end = 2f;
    public float second = 0;
    public string notetag = "note";
    public float radius = 0.1f;

    public int count = 0;
    public int combo = 0;
    public Text combotext;

    void Start()
    {
        startposition(gameobject);
        startposition(gameobject1);
        startposition(gameobject2);
        startposition(gameobject3);
        startposition(gameobject4);
        startposition(gameobject5);
        startposition(gameobject6);
        startposition(gameobject7);
        startposition(gameobject8);
        startposition(gameobject9);
        startposition(gameobject10);
        startposition(gameobject11);
        startposition(gameobject12);
        startposition(gameobject13);
        startposition(gameobject14);
        startposition(gameobject15);
        startposition(gameobject16);
        startposition(gameobject17);
        startposition(gameobject18);
        startposition(gameobject19);
        startposition(gameobject20);
        startposition(gameobject21);
        startposition(gameobject22);
        startposition(gameobject23);
        startposition(gameobject24);
        startposition(gameobject25);
        startposition(gameobject26);
        startposition(gameobject27);
        startposition(gameobject28);
        startposition(gameobject29);
        startposition(gameobject30);
        startposition(gameobject31);
        startposition(gameobject32);
        startposition(gameobject33);
        startposition(gameobject34);
        startposition(gameobject35);
        startposition(gameobject36);
        startposition(gameobject37);
        startposition(gameobject38);
        startposition(gameobject39);
        startposition(gameobject40);
        startposition(gameobject41);
        startposition(gameobject42);
        startposition(gameobject43);
        startposition(gameobject44);
        startposition(gameobject45);
        startposition(gameobject46);
        startposition(gameobject47);
        startposition(gameobject48);
        startposition(gameobject49);
        startposition(gameobject50);


        circleCollider = GetComponent<CircleCollider2D>();
    }
    void Update()
    {

        second += Time.deltaTime;

        Moveobject(gameobject);
        Moveobject(gameobject1);
        Moveobject(gameobject2);
        Moveobject(gameobject3);
        Moveobject(gameobject4);
        Moveobject(gameobject5);
        Moveobject(gameobject6);
        Moveobject(gameobject7);
        Moveobject(gameobject8);
        Moveobject(gameobject9);
        Moveobject(gameobject10);
        Moveobject(gameobject11);
        Moveobject(gameobject12);
        Moveobject(gameobject13);
        Moveobject(gameobject14);
        Moveobject(gameobject15);
        Moveobject(gameobject16);
        Moveobject(gameobject17);
        Moveobject(gameobject18);
        Moveobject(gameobject19);
        Moveobject(gameobject20);
        Moveobject(gameobject21);
        Moveobject(gameobject22);
        Moveobject(gameobject23);
        Moveobject(gameobject24);
        Moveobject(gameobject25);
        Moveobject(gameobject26);
        Moveobject(gameobject27);
        Moveobject(gameobject28);
        Moveobject(gameobject29);
        Moveobject(gameobject30);
        Moveobject(gameobject31);
        Moveobject(gameobject32);
        Moveobject(gameobject33);
        Moveobject(gameobject34);
        Moveobject(gameobject35);
        Moveobject(gameobject36);
        Moveobject(gameobject37);
        Moveobject(gameobject38);
        Moveobject(gameobject39);
        Moveobject(gameobject40);
        Moveobject(gameobject41);
        Moveobject(gameobject42);
        Moveobject(gameobject43);
        Moveobject(gameobject44);
        Moveobject(gameobject45);
        Moveobject(gameobject46);
        Moveobject(gameobject47);
        Moveobject(gameobject48);
        Moveobject(gameobject49);
        Moveobject(gameobject50);

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a");
            RaycastHit2D[] hits = Physics2D.CircleCastAll(transform.position, radius, Vector2.zero);

            if (hits.Length > 0)
            {
                System.Array.Sort(hits, (a, b) =>
                    Vector2.Distance(a.transform.position, transform.position)
                    .CompareTo(Vector2.Distance(b.transform.position, transform.position)));

                foreach (var hit in hits)
                {
                    if (hit.collider != null && hit.collider.CompareTag(notetag))
                    {
                        float distance = Mathf.Abs(hit.transform.position.x - transform.position.x);
                        if (distance < 0.1f)
                        {
                            Debug.Log("parfect");
                            animator.Play("per1", 0, 0f);
                            combo++;
                        }
                        else if (distance < 0.25f)
                        {
                            Debug.Log("good");
                            animator1.Play("good1", 0, 0f);
                            combo++;
                        }
                        else if (distance < 0.5f)
                        {
                            Debug.Log("normal");
                            animator2.Play("normal1", 0, 0f);
                            resetcombo();
                        }
                        else
                        {
                            Debug.Log("not");
                            animator3.Play("not1", 0, 0f);
                            resetcombo();
                            count++;
                            if (count >= 3)
                            {
                                SceneManager.LoadScene("Title");
                            }

                        }
                        combodayo();
                        Destroy(hit.collider.gameObject);

                        break;
                    }
                }
            }
        }
    }
            void Moveobject(GameObject obj)
            {
                if (obj != null)
                {
                    float currentSpeed = (obj == gameobject38 || obj == gameobject39) ? 10f : speed;

                    obj.transform.Translate(currentSpeed * Time.deltaTime, 0, 0);

                    obj.transform.Translate(speed * Time.deltaTime, 0, 0);
                    if (obj.transform.position.x >= end)
                    {
                        Debug.Log("miss");
                        animator4.Play("miss1", 0, 0f);
                resetcombo();
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

    void resetcombo()
    {
        combo = 0;

        combodayo();
    }

    void combodayo()
    {
        if (combotext != null)
        {
            if (combo > 0)
            {
                combotext.text = combo.ToString();
                combotext.enabled = true;
            }
            else
            {
                combotext.enabled = false;
            }
        }
    }
}