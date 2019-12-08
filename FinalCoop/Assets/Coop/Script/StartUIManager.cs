using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIManager : MonoBehaviour
{
    public GameObject optionUI; //옵션 선택창
    public GameObject score; //점수 채점화면(이전 게임)

    public void StartButton() //시험 시작! 버튼. 
    {
        optionUI.SetActive(true); //옵션 선택창 활성화
        score.SetActive(false); //이전에 점수 채점화면이 있었다면 비활성화
        gameObject.transform.parent.gameObject.SetActive(false); //시작 UI 비활성화
    }

    public void EndButton() //시험 종료 버튼. 게임을 종료한다.
    {
        Application.Quit();
    }
}
