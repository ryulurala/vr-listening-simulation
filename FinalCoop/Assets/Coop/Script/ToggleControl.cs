using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleControl : MonoBehaviour
{

    // 학용품 소음
    public void StationaryMany()
    {
        Debug.Log("StationaryMany()");
        SoundManager.soundManager.stationarySpeed = 10.0f;
    }
    public void StationaryLess()
    {
        Debug.Log("StationaryLess()");
        SoundManager.soundManager.stationarySpeed = 5f;
    }
    public void StationaryEmpty()
    {
        Debug.Log("StationaryEmpty()");
        SoundManager.soundManager.stationarySpeed = 0f;
    }

    // 감기 걸린 사람
    public void ColdPeopleMore()
    {
        Debug.Log("ColdPeopleMany()");
        SoundManager.soundManager.sneezeSpeed = 10.0f;
    }
    public void ColdPeopleLess()
    {
        Debug.Log("ColdPeopleLess()");
        SoundManager.soundManager.sneezeSpeed = 5.0f;
    }
    public void ColdPeopleEmpty()
    {
        Debug.Log("ColdPeopleEmpty()");
        SoundManager.soundManager.sneezeSpeed = 0f;
    }

    // 조는 사람
    public void SleepPeopleMany()
    {
        Debug.Log("SleepPeopleMany()");
        SoundManager.soundManager.yawnSpeed = 10.0f;
    }
    public void SleepPeopleLess()
    {
        Debug.Log("SleepPeopleLess()");
        SoundManager.soundManager.yawnSpeed = 5.0f;
    }
    public void SleepPeopleEmpty()
    {
        Debug.Log("SleepPeopleEmpty()");
        SoundManager.soundManager.yawnSpeed = 0f;
    }

    // 바깥 자동차 소음
    public void CarHornMany()
    {
        Debug.Log("CarHornMany()");
        SoundManager.soundManager.carHornSpeed = 10.0f;
    }
    public void CarHornLess()
    {
        Debug.Log("CarHornLess()");
        SoundManager.soundManager.carHornSpeed = 5.0f;
    }
    public void CarHornEmpty()
    {
        Debug.Log("CarHornEmpty");
        SoundManager.soundManager.carHornSpeed = 0f;
    }

    // 바깥 새 소음
    public void BirdMany()
    {
        Debug.Log("BirdMany()");
        SoundManager.soundManager.birdSpeed = 10.0f;
    }
    public void BirdLess()
    {
        Debug.Log("BirdLess()");
        SoundManager.soundManager.birdSpeed = 5.0f;
    }
    public void BirdEmpty()
    {
        Debug.Log("BirdEmpty()");
        SoundManager.soundManager.birdSpeed = 0f;
    }
}
