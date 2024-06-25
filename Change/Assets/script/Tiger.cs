using UnityEngine;
using System.Collections;

public class Tiger : MonoBehaviour
{
    public float countdown = 0.25f;
    public float speedupcountdown = 0.05f;
    public Animator animator;

    void Start()
    {
        StartCoroutine(CountDownSpeed());
    }

    IEnumerator CountDownSpeed()
    {
        if (animator == null)
        {
            yield break;
        }

        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2, 4));
            countdown = speedupcountdown;
            animator.SetBool("Run", true);
            yield return new WaitForSeconds(Random.Range(2.5f, 4));
            countdown = 0.25f;
            animator.SetBool("Run", false);
        }
    }
}