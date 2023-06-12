using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Pen : MonoBehaviour
{
    [SerializeField] GameObject obj;
    private Animator anim;
    private AudioSource myAudio;

    void Start()
    {
        anim = obj.GetComponent<Animator>();
        myAudio = obj.GetComponent<AudioSource>();
    }

    public void PlayAnim()
    {
        anim.SetTrigger("Play");
    }

    public void PlayAudio()
    {
        if (!myAudio.isPlaying)
        {
            myAudio.Play();
        }
    }
}
