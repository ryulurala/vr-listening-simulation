using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;

    public float stationarySpeed; // 학용품 소음
    public float sneezeSpeed; // 감기걸린 사람 
    public float yawnSpeed; // 조는 사람
    public float heaterVolume; // 히터 강도
    public float carHornSpeed; // 바깥 자동차 소음
    public float birdSpeed; // 바깥 새 소음
    public float listeningVolume; // 영어 듣기 볼륨

    private void Start()
    {
        soundManager = this;
    }
}
