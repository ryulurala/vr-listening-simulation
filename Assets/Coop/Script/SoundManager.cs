using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;

    public int stationarySpeed; // 학용품 소음
    public int sneezeSpeed; // 감기걸린 사람 
    public int yawnSpeed; // 조는 사람
    public int carHornSpeed; // 바깥 자동차 소음
    public int birdSpeed; // 바깥 새 소음


    public float heaterVolume; // 히터 강도
    public float listeningVolume; // 영어 듣기 볼륨

    private void Start()
    {
        soundManager = this;
        stationarySpeed = 2;
        sneezeSpeed = 2;
        yawnSpeed = 2;
        carHornSpeed = 2;
        birdSpeed = 2; 
    }
}
