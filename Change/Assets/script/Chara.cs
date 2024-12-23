using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Chara : MonoBehaviour
{
    public static Chara instance;
    public static int scenecount = 0;

    public GameObject chopstick;
    public GameObject soccerboll;
    public GameObject tire;
    public GameObject barrel;
    new Rigidbody rigidbody;
    Animator animator;
    string pickupturn;
    bool pickup = false;
    float pickcontlol = 1.2f;
    float pickTime = 0f;
    List<Vector3> Place = new List<Vector3>();

    public static int st1 = 0;

    void Start()
    {
        instance = this;

        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
        pickupturn = "Pickup";

        RandomObject(chopstick);
        RandomObject(soccerboll);
        RandomObject(tire);
        RandomObject(barrel);
    }

    void RandomObject(GameObject gameobject)
    {
        Vector3 randomPos;
        do
        {
            float posX = Random.Range(-3, 3);
            float posY = 0;
            float posZ = 0;
            if (gameobject == chopstick)
            {
                posY = -1.47f;
                posZ = -4.2f;
            }
            else if (gameobject == soccerboll)
            {
                posY = -0.88f;
                posZ = Random.Range(-4, -3);
            }
            else if (gameobject == tire)
            {
                posY = -0.8f;
                posZ = Random.Range(-4, 0);
            }
            else if (gameobject == barrel)
            {
                posY = -1f;
                posZ = Random.Range(-4, 0);
            }
            randomPos = new Vector3(posX, posY, posZ);
        } while (Loopposition(randomPos));

        Instantiate(gameobject, randomPos, Quaternion.identity);
        Place.Add(randomPos);
    }

    bool Loopposition(Vector3 pos)
    {
        foreach (Vector3 placedPos in Place)
        {
            if (Vector3.Distance(placedPos, pos) < 1.5f) 
            {
                return true;
            }
        }
        return false;
    }

    private void Update()
    {
        pick();
        if (!pickup)
        {
            move();
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }

    void move()
    {
        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            moveDirection += Vector3.back;
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveDirection += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveDirection += Vector3.right;
        }

        if (moveDirection != Vector3.zero)
        {
            transform.position += moveDirection.normalized * 0.002f;
            transform.rotation = Quaternion.LookRotation(moveDirection);
            animator.SetBool("Run", true);
        }
        else
        {
            animator.SetBool("Run", false);
        }
    }

    void pick()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position + Vector3.up * 0.5f, transform.forward, out hit, 0.5f))
            {
                if (hit.collider.CompareTag(pickupturn))
                {
                    animator.SetBool("Pickup", true);
                    hit.collider.gameObject.SetActive(false);
                    pickup = true;
                    pickTime = Time.time + pickcontlol;
                }
            }
        }

        if (pickup && Time.time >= pickTime)
        {
            animator.SetBool("Pickup", false);
            pickup = false;
            if (pickupturn == "Pickup")
                pickupturn = "Pickup2";
            else if (pickupturn == "Pickup2")
                pickupturn = "Pickup3";
            else if (pickupturn == "Pickup3")
                pickupturn = "Pickup4";
            else if (pickupturn == "Pickup4")
                pickupturn = "Pickup5";
            else if (pickupturn == "Pickup5")
            {
                st1++;
                NextScene();
            }
        }
    }

    public static void NextScene()
    {
        scenecount++;
        if (scenecount >= 3)
        {
            SceneManager.LoadScene("Title1");
        }
        else
        {
            SceneManager.LoadScene("Title");
        }
    }
}