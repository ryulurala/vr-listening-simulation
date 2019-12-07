using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentControl : MonoBehaviour
{
    [Header("SFX Source")]
    public AudioSource yawn;
    public AudioSource sneeze;
    public AudioSource paperFlip;
    public AudioSource penDrop;
    public AudioSource penStroke;

    public void YawnPlay()
    {
        yawn.Play();
    }

    public void SneezePlay()
    {
        sneeze.Play();
    }

    public void PaperFlipPlay()
    {
        paperFlip.Play();
    }

    public void PenDropPlay()
    {
        penDrop.Play();
    }

    public void PenStrokePlay()
    {
        penStroke.Play();
    }

}
