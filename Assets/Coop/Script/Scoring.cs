using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// by 정민기, 풀이한 시험지를 채점하는 스크립트
/// </summary>
public class Scoring : MonoBehaviour
{
    private int[] correctAnswer = new int[18]; //실제 정답
    public GameObject omr; //OMR 오브젝트의 캔버스를 가져온다.

    private void OnEnable()
    {
        correctAnswer[1] = 1; //정답 입력
        correctAnswer[2] = 2;
        correctAnswer[3] = 1;
        correctAnswer[4] = 3;
        correctAnswer[5] = 3;
        correctAnswer[6] = 4;
        correctAnswer[7] = 4;
        correctAnswer[8] = 5;
        correctAnswer[9] = 2;
        correctAnswer[10] = 3;
        correctAnswer[11] = 4;
        correctAnswer[12] = 4;
        correctAnswer[13] = 2;
        correctAnswer[14] = 2;
        correctAnswer[15] = 5;
        correctAnswer[16] = 1;
        correctAnswer[17] = 3;

        scoreCheck(); //채점 함수 호출
    }

    public void scoreCheck() //채점 함수
    {
        for (int i = 1; i <= 17; i++) 
        {
            if (omr.transform.GetChild(i).GetChild(correctAnswer[i] - 1).GetComponent<Toggle>().isOn) //정답번호의 토글이 true면 정답, 아니면 오답
            {
                transform.GetChild(i + 1).GetComponent<AnswerCheck>().GoodAnswer();
            }
            else
            {
                Debug.Log(i);
                transform.GetChild(i + 1).GetComponent<AnswerCheck>().BadAnswer();
            }
        }
    }
}
