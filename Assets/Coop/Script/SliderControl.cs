using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// by 정민기, 옵션 선택 UI에서 에어컨과 스피커 볼륨 설정값을 슬라이더로 받는 스크립트
/// </summary>
public class SliderControl : MonoBehaviour
{
    public Slider heater; // 에어컨 설정값 슬라이더
    public Slider listening; // 스피커 설정값 슬라이더

    [SerializeField] private GameObject airconditional; // 에어컨 오브젝트
    [SerializeField] private GameObject speaker; // 스피커 오브젝트

    /// <summary>
    /// 에어컨 설정값 슬라이더에 붙일 에어컨 볼륨 설정 함수
    /// </summary>
    public void HeaterVolume()
    {
        if (heater.value > 0)
        {
            airconditional.GetComponent<Animator>().enabled = true;
        }
        else
        {
            airconditional.GetComponent<Animator>().enabled = false;
        }
        airconditional.GetComponent<AudioSource>().volume = SoundManager.soundManager.heaterVolume = heater.value;
    }

    /// <summary>
    /// 스피커 설정값 슬라이더에 붙일 영어 듣기 볼륨 설정 함수
    /// </summary>
    public void ListeningVolume()
    {
        speaker.GetComponent<AudioSource>().volume = SoundManager.soundManager.listeningVolume = listening.value;
    }
}
