using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// by 정민기, 시험 문제를 이전 문제나 다음 문제로 바꿔 출력하는 스크립트
/// </summary>
public class TestChange : MonoBehaviour
{
    public Sprite[] questions; // 시험번호별 이미지 스프라이트
    Image image; // 현재 이미지 변수
    int nowQuestion; //현재 출력하고 있는 시험 번호

    /// <summary>
    /// 시험지 UI가 활성화 될 때 1번 문제부터 출력한다
    /// </summary>
    public void OnEnable()
    {
        image = gameObject.GetComponent<Image>();
        nowQuestion = 1;
        image.sprite = questions[nowQuestion];
    }

    /// <summary>
    /// 이전 문제를 출력한다
    /// </summary>
    public void BeforeQuestion()
    {
        if(nowQuestion != 1) // 현재 시험번호가 1이 아니라면 현재 시험번호 -1인 문제를 출력한다.
        {
            nowQuestion -= 1;
            image.sprite = questions[nowQuestion];

        }

    }

    /// <summary>
    /// 다음 문제를 출력한다.
    /// </summary>
    public void AfterQuestion()
    {
        if(nowQuestion != 16) // 현재 시험번호가 16(마지막 문제)이 아니라면 현재 시험번호 +1인 문제를 출력한다.
        {
            nowQuestion += 1;
            image.sprite = questions[nowQuestion];
        }

    }
}
