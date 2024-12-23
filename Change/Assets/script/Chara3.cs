using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chara3 : MonoBehaviour
{

    public Animator animator;
    public float start = 0f;
    public bool dance = false;
    public AudioClip bgm;
    public AudioSource song;
    public bool onemusic = false;
    public static int st3 = 0;
    public Animator songname;

    void Start()
    {
        song = gameObject.AddComponent<AudioSource>();
        song.clip = bgm;
        songname.SetTrigger("songname");

    }

    void Update()
    {
            start += Time.deltaTime;
            if (!dance && start >= 3.5f)
            {
                animator.SetTrigger("dance1");
                dance = true;
            }

        if (start >= 6.5f && !onemusic)
        {
            song.Play();
            onemusic = true;
        }

        if (start >= 25.5f)
        {
            animator.SetTrigger("dance5");
        }

        if (start >= 27f)
        {
            animator.SetTrigger("dance3");
        }

        if (start >= 29.2f)
        {
            animator.SetTrigger("dance4");
        }

        if (start >= 37.5f)
            {
            st3++;
                Chara.NextScene();
            }
    }
}
