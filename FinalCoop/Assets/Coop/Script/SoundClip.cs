using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundClip : MonoBehaviour
{
    private AudioSource audioSource;

    [Header("AudioClip")]
    public AudioClip[] audioClips;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void InputSound()
    {
        audioSource.clip = audioClips[(int)Random.Range(0, audioClips.Length+1)];
    }

    public void InputSound(int index)
    {
        audioSource.clip = audioClips[index];
    }
}
