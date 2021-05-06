using UnityEngine;
using UnityEngine.Playables;

/// <summary>
/// by 정민기, 시험 시작 전 옵션 설정 스크립트
/// </summary>
public class OptionUIManager : MonoBehaviour
{
    public GameObject startUI; // 게임 시작시 UI
    public GameObject testUI; // 시험지 UI

    public GameObject personManager; // 학생 매니저 오브젝트
    public GameObject outsideSounds; // 환경음 매니저 오브젝트

    public GameObject player; // 플레이어 오브젝트
    public Transform[] testStartObject; // 플레이어 위치 조정용 오브젝트

    public GameObject omr; // OMR 오브젝트
    public GameObject deskChoice; // 좌석 선택 UI 오브젝트

    public PlayableDirector playableDirector; // 감독관 입장 애니메이션

    public GameObject aircon; // 에어컨 오브젝트
    public GameObject speaker; // 영어듣기 스피커 오브젝트

    /// <summary>
    /// 시험을 시작하는 함수
    /// </summary>
    public void GameStart()
    {
        playableDirector.Play(); // 감독관 입장 애니메이션 실행
        Invoke("AfterStart", 2.5f); // 감독관 입장 애니메이션 종료 후 AfterStart() 함수를 실행한다.
        
    }

    /// <summary>
    /// 게임 시작 UI로 돌아가는 함수
    /// </summary>
    public void BackButton() 
    {
        startUI.SetActive(true); // 게임 시작 UI를 활성화한다
        gameObject.transform.parent.gameObject.SetActive(false); // 옵션 선택 UI를 비활성화한다
    }

    /// <summary>
    /// 시험이 시작된 후 플레이어 외 학생들을 배치하고 학생 매니저, 소리 매니저를 활성화한다.
    /// </summary>
    void AfterStart()
    {
        aircon.GetComponent<AudioSource>().Play(); // 에어컨의 소리를 켠다
        speaker.GetComponent<AudioSource>().Play(); // 스피커에서 영어 듣기를 시작한다.
        personManager.SetActive(true); // 학생, 소리 매니저를 활성화한다.
        outsideSounds.SetActive(true); // 환경음 소리를 켠다.

        int testPosition = deskChoice.GetComponent<DeskChange>().NowDesk(); // DeskChange() 함수에서 플레이어가 설정한 플레이어 좌석을 가져온다
        switch (testPosition) // 플레이어(카메라)를 플레이어가 설정한 좌석으로 이동시킨다
        {
            case 11:
                player.transform.position = testStartObject[1].position + new Vector3(0, -0.45f, 0);
                testStartObject[1].gameObject.SetActive(false);
                break;
            case 12:
                player.transform.position = testStartObject[2].position + new Vector3(0, -0.45f, 0);
                testStartObject[2].gameObject.SetActive(false);
                break;
            case 13:
                player.transform.position = testStartObject[3].position + new Vector3(0, -0.45f, 0);
                testStartObject[3].gameObject.SetActive(false);
                break;
            case 14:
                player.transform.position = testStartObject[4].position + new Vector3(0, -0.45f, 0);
                testStartObject[4].gameObject.SetActive(false);
                break;
            case 21:
                player.transform.position = testStartObject[5].position + new Vector3(0, -0.45f, 0);
                testStartObject[5].gameObject.SetActive(false);
                break;
            case 22:
                player.transform.position = testStartObject[6].position + new Vector3(0, -0.45f, 0);
                testStartObject[6].gameObject.SetActive(false);
                break;
            case 23:
                player.transform.position = testStartObject[7].position + new Vector3(0, -0.45f, 0);
                testStartObject[7].gameObject.SetActive(false);
                break;
            case 24:
                player.transform.position = testStartObject[8].position + new Vector3(0, -0.45f, 0);
                testStartObject[8].gameObject.SetActive(false);
                break;
            case 31:
                player.transform.position = testStartObject[9].position + new Vector3(0, -0.45f, 0);
                testStartObject[9].gameObject.SetActive(false);
                break;
            case 32:
                player.transform.position = testStartObject[10].position + new Vector3(0, -0.45f, 0);
                testStartObject[10].gameObject.SetActive(false);
                break;
            case 33:
                player.transform.position = testStartObject[11].position + new Vector3(0, -0.45f, 0);
                testStartObject[11].gameObject.SetActive(false);
                break;
            case 34:
                player.transform.position = testStartObject[12].position + new Vector3(0, -0.45f, 0);
                testStartObject[12].gameObject.SetActive(false);
                break;
            case 41:
                player.transform.position = testStartObject[13].position + new Vector3(0, -0.45f, 0);
                testStartObject[13].gameObject.SetActive(false);
                break;
            case 42:
                player.transform.position = testStartObject[14].position + new Vector3(0, -0.45f, 0);
                testStartObject[14].gameObject.SetActive(false);
                break;
            case 43:
                player.transform.position = testStartObject[15].position + new Vector3(0, -0.45f, 0);
                testStartObject[15].gameObject.SetActive(false);
                break;
            case 44:
                player.transform.position = testStartObject[16].position + new Vector3(0, -0.45f, 0);
                testStartObject[16].gameObject.SetActive(false);
                break;
            case 51:
                player.transform.position = testStartObject[17].position + new Vector3(0, -0.45f, 0);
                testStartObject[17].gameObject.SetActive(false);
                break;
            case 52:
                player.transform.position = testStartObject[18].position + new Vector3(0, -0.45f, 0);
                testStartObject[18].gameObject.SetActive(false);
                break;
            case 53:
                player.transform.position = testStartObject[19].position + new Vector3(0, -0.45f, 0);
                testStartObject[19].gameObject.SetActive(false);
                break;
            case 54:
                player.transform.position = testStartObject[20].position + new Vector3(0, -0.45f, 0);
                testStartObject[20].gameObject.SetActive(false);

                break;

        }


        testUI.SetActive(true); // 시험지 UI 활성화
        omr.SetActive(true); // OMR UI 활성화


        gameObject.transform.parent.gameObject.SetActive(false); // 옵션 선택 UI 비활성화
        return;
    }

}
