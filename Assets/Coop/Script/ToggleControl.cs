using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleControl : MonoBehaviour
{

    // 학용품 소음
    public void StationaryHigh()
    {
        SoundManager.soundManager.stationarySpeed = 2;
    }
    public void StationaryLow()
    {
        SoundManager.soundManager.stationarySpeed = 1;
    }
    public void StationaryZero()
    {
        SoundManager.soundManager.stationarySpeed = 0;
    }

    // 감기 걸린 사람
    public void ColdPeopleHigh()
    {
        SoundManager.soundManager.sneezeSpeed = 2;
    }
    public void ColdPeopleLow()
    {
        SoundManager.soundManager.sneezeSpeed = 1;
    }
    public void ColdPeopleZero()
    {
        SoundManager.soundManager.sneezeSpeed = 0;
    }

    // 조는 사람
    public void SleepPeopleHigh()
    {
        SoundManager.soundManager.yawnSpeed = 2;
    }
    public void SleepPeopleLow()
    {
        SoundManager.soundManager.yawnSpeed = 1;
    }
    public void SleepPeopleZero()
    {
        SoundManager.soundManager.yawnSpeed = 0;
    }

    // 바깥 자동차 소음
    public void CarHornHigh()
    {
        SoundManager.soundManager.carHornSpeed = 2;
    }
    public void CarHornLow()
    {
        SoundManager.soundManager.carHornSpeed = 1;
    }
    public void CarHornZero()
    {
        SoundManager.soundManager.carHornSpeed = 0;
    }

    // 바깥 새 소음
    public void BirdHigh()
    {
        SoundManager.soundManager.birdSpeed = 2;
    }
    public void BirdLow()
    {
        SoundManager.soundManager.birdSpeed = 1;
    }
    public void BirdZero()
    {
        SoundManager.soundManager.birdSpeed = 0;
    }
}
