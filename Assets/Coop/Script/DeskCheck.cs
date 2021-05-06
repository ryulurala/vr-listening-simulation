using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// by 정민기, 좌석 선택 UI값을 받아 좌석 변경 함수를 호출하는 스크립트
/// </summary>
public class DeskCheck : MonoBehaviour
{
    Toggle toggle; // 좌석 선택 UI
    
    //게임이 시작될 때, 좌석 선택 UI를 toggle 변수에 할당한다.
    private void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
    }
    
    /// <summary>
    /// 좌석 선택 UI값이 변경될 때마다 DeskChange 클래스의 CheckDesk() 함수를 호출하여 플레이어의 시작 좌석을 변경한다.
    /// 좌석 선택 UI들은 toggle group으로 묶여있기 때문에 하나만 on되고, on이 된 toggle만 if문 내의 문장을 실행한다.
    /// </summary>
    public void ToggleChange()
    {
        if(toggle.isOn)
        {
            transform.parent.GetComponent<DeskChange>().CheckDesk(gameObject.name);
        }
    }
}
