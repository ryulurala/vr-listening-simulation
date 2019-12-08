using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionUIManager : MonoBehaviour
{
    public GameObject startUI;
    public GameObject testUI;

    public void GameStart() //시험을 시작한다.
    {
        GameObject personManager = GameObject.Find("PersonManager"); //학생 매니저
        GameObject outsideSound = GameObject.Find("OutSideSounds"); //소리 매니저

        personManager.SetActive(true); //학생, 소리 매니저를 활성화한다.
        outsideSound.SetActive(true);
    }

    public void BackButton() //시작 UI로 돌아간다.
    {
        startUI.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

}
