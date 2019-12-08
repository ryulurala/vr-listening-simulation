using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitUIManager : MonoBehaviour //시험 도중 게임 종료 버튼
{
    public GameObject score; //점수 채점
    public GameObject startUI; //시작 화면

    public void ExitGame() //점수를 채점하고 칠판에 시작 UI를 다시 불러온다.
    {
        score.SetActive(true);
        startUI.SetActive(true);

        GameObject personManager = GameObject.Find("PersonManager"); //학생 매니저
        GameObject outsideSound = GameObject.Find("OutSideSounds"); //소리 매니저

        personManager.SetActive(false); //학생, 소리 매니저를 비활성화한다.
        outsideSound.SetActive(false);

        gameObject.SetActive(false); //자기 자신은 비활성화한다.
    }
}
