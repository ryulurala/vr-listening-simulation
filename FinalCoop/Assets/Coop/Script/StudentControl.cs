using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentControl : MonoBehaviour
{
    private AudioSource studentAudioSource;
    private SoundClip soundClip;
    private Animator animator;

    void Start()
    {
        studentAudioSource = gameObject.GetComponent<AudioSource>();
        soundClip = gameObject.GetComponent<SoundClip>();
        animator = gameObject.GetComponent<Animator>();
    }

    public void Yawn1Play()
    {
        soundClip.InputSound(5);
        studentAudioSource.Play();

    }
    public void Yawn2Play()
    {
        soundClip.InputSound(6);
        studentAudioSource.Play();
    }

    public void Sneeze1Play()
    {
        soundClip.InputSound(0);
        studentAudioSource.Play();
    }

    public void Sneeze2Play()
    {
        soundClip.InputSound(1);
        studentAudioSource.Play();
    }

    public void PaperFlipPlay()
    {
        soundClip.InputSound(2);
        studentAudioSource.Play();
    }

    public void PenDropPlay()
    {
        soundClip.InputSound(4);
        studentAudioSource.Play();
    }

    public void PenStrokePlay()
    {
        soundClip.InputSound(3);
        studentAudioSource.Play();
    }

}
