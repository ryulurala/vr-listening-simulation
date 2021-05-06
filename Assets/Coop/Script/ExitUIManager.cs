using UnityEngine;

/// <summary>
/// by 정민기, 시험 종료 시 시험 시작 전 환경을 다시 세팅해주는 스크립트
/// </summary>
public class ExitUIManager : MonoBehaviour // 시험 도중 게임 종료 버튼
{
    public GameObject score; // 점수 채점 오브젝트
    public GameObject omr; // 답지 오브젝트
    public GameObject startUI; // 시작 화면 UI 오브젝트

    public GameObject personManager; // 학생 매니저 오브젝트
    public GameObject outsideSounds; // 환경음 매니저 오브젝트

    public GameObject player; // 플레이어 오브젝트
    public GameObject playerStartObject; // 게임 시작 시 카메라 위치 고정용 오브젝트

    public GameObject aircon; // 에어컨 매니저 오브젝트
    public GameObject speaker; // 스피커(영어듣기) 매니저 오브젝트

    public void ExitGame() //점수를 채점하고 칠판에 시작 UI를 다시 불러온다.
    {
        speaker.GetComponent<AudioSource>().Stop(); // 스피커 소리 정지
        aircon.GetComponent<AudioSource>().Stop(); // 에어컨 가동음 정지

        score.SetActive(true); // 채점지 오브젝트 활성화
        startUI.SetActive(true); // 시험 시작 UI 활성화
        omr.SetActive(false); // OMR 오브젝트 비활성화

        // 플레이어가 있던 좌석을 포함해 학생들을 모두 활성화 시킨 후, 학생들의 부모 오브젝트를 비활성화 시킨다.
        for (int i = 0; i < 20; i++)
        {
            personManager.transform.GetChild(i).gameObject.SetActive(true);
        }
        personManager.SetActive(false);

        outsideSounds.SetActive(false);  // 환경음 매니저 오브젝트 비활성화

        player.transform.position = playerStartObject.transform.position; // 플레이어 위치를 게임 시작시 위치로 변환

        gameObject.SetActive(false); // 게임 종료 UI 비활성화
    }
}
