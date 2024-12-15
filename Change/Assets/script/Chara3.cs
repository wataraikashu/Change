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

    void Start()
    {
        song = gameObject.AddComponent<AudioSource>();
        song.clip = bgm;
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

        if (start >= 37.5f)
            {
                Chara.NextScene();
            }
    }
}
