using UnityEngine;

/// <summary>
/// by 정민기, 게임 시작시 UI 설정 스크립트
/// </summary>
public class StartUIManager : MonoBehaviour
{
    public GameObject optionUI; //옵션 선택 UI
    public GameObject score; //점수 채점화면(이전 게임)

    public void StartButton() //시험 시작! 버튼. 
    {
        optionUI.SetActive(true); // 옵션 선택 UI 활성화
        score.SetActive(false); // 시험 채점 후 시작 UI로 돌아왔다면 채점지 UI 비활성화

        gameObject.transform.parent.gameObject.SetActive(false); //시작 UI 비활성화
    }

    public void EndButton() //시험 종료 버튼. 게임을 종료한다.
    {
        Application.Quit();
    }
}
