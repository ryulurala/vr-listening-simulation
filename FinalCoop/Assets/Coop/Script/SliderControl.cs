using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Slider heater;
    public Slider listening;

    [SerializeField] private GameObject airconditional;
    [SerializeField] private GameObject speaker;

    // 히터 볼륨
    public void HeaterVolume()
    {
        airconditional.GetComponent<AudioSource>().volume = SoundManager.soundManager.heaterVolume = heater.value;
    }

    // 영어 듣기 볼륨
    public void ListeningVolume()
    {
        airconditional.GetComponent<AudioSource>().volume = SoundManager.soundManager.listeningVolume = listening.value;
    }
}
