using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string soundName;
    public AudioClip clip; // mp3 file
}

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    [Header("Sound Input")]
    [SerializeField] Sound[] bgmSounds; // Background Mulsic Array, ex) Class 1, Class 2, etc...
    [SerializeField] Sound[] sfxSounds; // Sound Effect

    [Header("BGM Player")]
    [SerializeField] AudioSource bgmPlayer;

    [Header("SFX Player")]
    [SerializeField] AudioSource[] sfxPlayer;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        PlayBGM();
    }

    // Background music func
    public void PlayBGM()
    {
        bgmPlayer.clip = bgmSounds[0].clip; // Input bgm clip
        bgmPlayer.Play();
    }

    // Sound effect func
    public void PlaySE(string _soundName)
    {
        for(int i=0; i<sfxSounds.Length; i++)
        {
            if(_soundName == sfxSounds[i].soundName)
            {
                for(int j=0; j<sfxPlayer.Length; j++)
                {
                    if (!sfxPlayer[j].isPlaying)
                    {
                        sfxPlayer[j].clip = sfxSounds[i].clip;
                        sfxPlayer[j].Play();
                        return;
                    }
                }
                Debug.Log("All Audio Source is playing, Input more Audio source ");
                return;
            }
        }
        Debug.Log("SFX is nothing");
    }
}
