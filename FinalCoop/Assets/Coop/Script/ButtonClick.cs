using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : MonoBehaviour
{
    private Toggle toggle;
    private Slider slider;

    private void Start()
    {
        switch (gameObject.name)
        {
            case "High": //토글일 경우 토글 선언
            case "Low":
            case "Zero":
            case "A1": 
            case "A2":
            case "A3":
            case "A4":
            case "A5":
            case "Desk11":
            case "Desk12":
            case "Desk13":
            case "Desk14":
            case "Desk21":
            case "Desk22":
            case "Desk23":
            case "Desk24":
            case "Desk31":
            case "Desk32":
            case "Desk33":
            case "Desk34":
            case "Desk41":
            case "Desk42":
            case "Desk43":
            case "Desk44":
            case "Desk51":
            case "Desk52":
            case "Desk53":
            case "Desk54":
                toggle = gameObject.GetComponent<Toggle>();
                break;

            case "Slider": //슬라이더일 경우 슬라이더 선언
                slider = gameObject.GetComponent<Slider>();
                break;
        }
    }

    private void OnEnable()
    {
        switch (gameObject.name)
        {
            case "A1":
            case "A2":
            case "A3":
            case "A4":
            case "A5":
                toggle = gameObject.GetComponent<Toggle>();
                toggle.isOn = false;
                break;
        }
    }

    public void OnClick()
    {
        switch (gameObject.name) //버튼마다 실행되는 함수가 달라지게 한다.
        {
            case "StartGame": //게임 시작 UI에서 시험 시작!을 눌렀을 경우
                gameObject.GetComponent<StartUIManager>().StartButton();
                break;
            case "ExitGame": //게임 시작 UI에서 시험 종료를 눌렀을 경우
                gameObject.GetComponent<StartUIManager>().EndButton();
                break;
            case "StartButton": //옵션 UI에서 시험 시작!을 눌렀을 경우
                gameObject.GetComponent<OptionUIManager>().GameStart();
                break;
            case "BackButton": //옵션 UI에서 뒤로가기를 눌렀을 경우
                gameObject.GetComponent<OptionUIManager>().BackButton();
                break;
            case "ExitGame_Test": //시험 도중 UI에서 시험 종료를 눌렀을 경우
                gameObject.GetComponent<ExitUIManager>().ExitGame();
                break;

            case "Slider": //옵션 UI에서 슬라이더를 눌렀을 경우 증가하다가 꽉차면 다시 0부터 시작한다.
                if (slider.value == 1)
                    slider.value = 0;
                slider.value += 0.01f;
                break;

            case "High": //옵션 UI에서 토글을 눌렀을 경우 온
            case "Low":
            case "Zero":
                toggle.isOn = true;
                break;

            case "A1": //OMR답안지에서 토글을 눌렀을 경우 온
            case "A2":
            case "A3":
            case "A4":
            case "A5":
                toggle.isOn = true;
                break;

            case "Desk11":
            case "Desk12":
            case "Desk13":
            case "Desk14":
            case "Desk21":
            case "Desk22":
            case "Desk23":
            case "Desk24":
            case "Desk31":
            case "Desk32":
            case "Desk33":
            case "Desk34":
            case "Desk41":
            case "Desk42":
            case "Desk43":
            case "Desk44":
            case "Desk51":
            case "Desk52":
            case "Desk53":
            case "Desk54":
                toggle.isOn = true;
                break;
        }
    }
}
