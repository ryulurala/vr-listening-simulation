using UnityEngine;

/// <summary>
/// by 정민기, 좌석 선택 UI 값을 받아 시험시 플레이어의 위치를 저장하는 스크립트
/// </summary>
public class DeskChange : MonoBehaviour
{
    private int nowDesk; // 플레이어가 시험을 시작하는 책상의 위치. 값이 12일 경우, 1행 2열에 위치한 책상에서 시작한다. 

    // 게임이 시작될 때, 플레이어의 위치를 1행 1열로 초기화한다.
    public void Start()
    {
        nowDesk = 11;
    }

    /// <summary>
    /// 좌석 선택 UI를 활용해 좌석을 변경했을 때 호출되어 nowDesk(플레이어의 좌석)을 변경하는 함수
    /// </summary>
    /// <param name="checkToggle">플레이어가 선택한 toggle의 이름</param>
    public void CheckDesk(string checkToggle)
    {
        switch (checkToggle)
        {
            case "Desk11":
                nowDesk = 11;
                break;
            case "Desk12":
                nowDesk = 12;
                break;
            case "Desk13":
                nowDesk = 13;
                break;
            case "Desk14":
                nowDesk = 14;
                break;
            case "Desk21":
                nowDesk = 21;
                break;
            case "Desk22":
                nowDesk = 22;
                break;
            case "Desk23":
                nowDesk = 23;
                break;
            case "Desk24":
                nowDesk = 24;
                break;
            case "Desk31":
                nowDesk = 31;
                break;
            case "Desk32":
                nowDesk = 32;
                break;
            case "Desk33":
                nowDesk = 33;
                break;
            case "Desk34":
                nowDesk = 34;
                break;
            case "Desk41":
                nowDesk = 41;
                break;
            case "Desk42":
                nowDesk = 42;
                break;
            case "Desk43":
                nowDesk = 43;
                break;
            case "Desk44":
                nowDesk = 44;
                break;
            case "Desk51":
                nowDesk = 51;
                break;
            case "Desk52":
                nowDesk = 52;
                break;
            case "Desk53":
                nowDesk = 53;
                break;
            case "Desk54":
                nowDesk = 54;
                break;
        }
    }

    /// <summary>
    /// 현재 선택된 플레이어의 좌석을 반환하는 함수
    /// </summary>
    /// <returns>현재 선택된 플레이어의 좌석</returns>
    public int NowDesk()
    {
        return nowDesk;
    }
}
