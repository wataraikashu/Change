using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit : MonoBehaviour
{
    private CircleCollider2D circleCollider;

    public string tag = "note";
    public float radius = 0.5f;

    void Start()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("a");
            RaycastHit2D hit = Physics2D.CircleCast(transform.position, radius, Vector2.zero);

            if (hit.collider != null && hit.collider.CompareTag(tag))
            {
                Debug.Log("ab");
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