using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour
{
    private Toggle userAnswer;
    private int[] correctAnswer = new int[18]; //실제 정답
    public GameObject omr;

    void Start()
    {
        correctAnswer[1] = 1;
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
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            scoreCheck(omr);
            Debug.Log("good!");
        }
    }

    public void scoreCheck(GameObject OMR)
    {
        Debug.Log("aaa");
        for (int i = 1; i <= 17; i++) 
        {
            Debug.Log("sssssssssssssssssssssss");
            if (OMR.transform.GetChild(i).GetChild(correctAnswer[i] - 1).GetComponent<Toggle>().isOn)
            {
                Debug.Log("yes");

                transform.GetChild(i + 1).GetComponent<AnswerCheck>().GoodAnswer();
            }
            else
            {
                Debug.Log("no");

                transform.GetChild(i + 1).GetComponent<AnswerCheck>().BadAnswer();
            }
        }
    }
}
