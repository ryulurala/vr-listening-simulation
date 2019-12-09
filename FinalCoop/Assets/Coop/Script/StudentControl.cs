using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentControl : MonoBehaviour
{
    private AudioSource studentAudioSource;
    private SoundClip soundClip;
    private Animator animator;

    private int sneezeInput;
    private int yawnIntput;

    private float statinaryDelayTime;
    private bool stationaryCheck;

    private float sneezeDelayTime;
    private bool sneezeCheck;

    private float yawnDelayTime;
    private bool yawnCheck;

    private bool BehaviorCheck;

    private int randNum;
    void Start()
    {
        studentAudioSource = gameObject.GetComponent<AudioSource>();
        soundClip = gameObject.GetComponent<SoundClip>();
        animator = gameObject.GetComponent<Animator>();

        sneezeInput = Random.Range(1, 3); // 1~2
        yawnIntput = Random.Range(1, 3); // 1~2

        BehaviorCheck = false;
    }

    void Update()
    {
        if (!BehaviorCheck)
        {
            StartCoroutine(RandomeBehavior());
        }
    }

    IEnumerator RandomeBehavior()
    {
        if (SoundManager.soundManager.stationarySpeed != 0)
        {
            StartCoroutine(StationaryControl());
            StartCoroutine(SneezeControl());
            StartCoroutine(YawnControl());
        }
        yield return null;
    }
    IEnumerator StationaryControl()
    {
        BehaviorCheck = true;
        switch (SoundManager.soundManager.stationarySpeed)
        {
            case 1: // 적음
                statinaryDelayTime = Random.Range(500, 15000);
                break;
            case 2: // 많음
                statinaryDelayTime = Random.Range(150, 3000);
                break;
        }

        Invoke("Stationary", statinaryDelayTime / 10);

        yield return null;

    }

    public void Stationary()
    {
        Debug.Log("Stationary()" + gameObject.name);
        if (animator.GetInteger("Sit_State") == 0)
        {
            int percent = Random.Range(1, 11);

            if (percent >= 1 && percent <= 8)
            {
                animator.SetInteger("Sit_State", 3);
            }
            else if (percent == 9)
            {
                animator.SetInteger("Sit_State", 2);
            }
            else
            {
                animator.SetInteger("Sit_State", 4);
            }
        }
        BehaviorCheck = false;
    }

    IEnumerator SneezeControl()
    {
        BehaviorCheck = true;

        switch (SoundManager.soundManager.sneezeSpeed)
        {
            case 1: // 적음
                sneezeDelayTime = Random.Range(800, 30000);
                break;
            case 2: // 많음
                sneezeDelayTime = Random.Range(500, 5000);
                break;
        }

        Invoke("Sneeze", sneezeDelayTime / 5);

        yield return null;

    }

    public void Sneeze()
    {
        Debug.Log("Sneeze()" + gameObject.name);
        if (animator.GetInteger("Sit_State") == 0)
        {
            animator.SetInteger("Sit_State", 1);
        }
        BehaviorCheck = false;
    }

    IEnumerator YawnControl()
    {
        BehaviorCheck = true;
        switch (SoundManager.soundManager.yawnSpeed)
        {
            case 1: // 적음
                yawnDelayTime = Random.Range(800, 30000);
                break;
            case 2: // 많음
                yawnDelayTime = Random.Range(500, 5000);
                break;
        }
        Invoke("Yawn", yawnDelayTime / 5);

        yield return null;

    }

    public void Yawn()
    {
        Debug.Log("Yawn()" + gameObject.name);
        if (animator.GetInteger("Sit_State") == 0)
        {
            int percent = Random.Range(1, 6);

            if (percent < 4)
            {
                animator.SetInteger("Sit_State", 6);
            }
            else
            {
                animator.SetInteger("Sit_State", 7);
            }
        }

        BehaviorCheck = false;
    }

    public void Yawn1Play()
    {
        if (yawnIntput == 1)
        {
            soundClip.InputSound(5);
            studentAudioSource.Play();
        }

    }
    public void Yawn2Play()
    {
        if (yawnIntput == 2)
        {
            soundClip.InputSound(6);
            studentAudioSource.Play();
        }
    }

    public void Sneeze1Play()
    {
        if (sneezeInput == 1)
        {
            soundClip.InputSound(0);
            studentAudioSource.Play();
        }
    }

    public void Sneeze2Play()
    {
        if (sneezeInput == 2)
        {
            soundClip.InputSound(1);
            studentAudioSource.Play();
        }
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