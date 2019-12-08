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
        toggle = gameObject.GetComponent<Toggle>();

        if(gameObject.name == "Slider")
            slider = gameObject.GetComponent<Slider>();
    }

    public void OnClick()
    {
        switch (gameObject.name) //버튼마다 실행되는 함수가 달라지게 한다.
        {
            case "StartGame": //게임 스타트 버튼을 눌렀을 경우
                gameObject.GetComponent<StartUIManager>().StartButton();
                break;
            case "ExitGame":
                gameObject.GetComponent<StartUIManager>().EndButton();
                break;
            case "StartButton":
                gameObject.GetComponent<OptionUIManager>().GameStart();
                break;
            case "BackButton":
                gameObject.GetComponent<OptionUIManager>().BackButton();
                break;

            case "Slider":
                if (slider.value == 1)
                    slider.value = 0;
                slider.value += 0.01f;
                break;

            case "High":
            case "Low":
            case "Zero":
                toggle.isOn = true;
                break;

            case "A1":
            case "A2":
            case "A3":
            case "A4":
            case "A5":
                toggle.isOn = true;
                break;
        }
    }
}
