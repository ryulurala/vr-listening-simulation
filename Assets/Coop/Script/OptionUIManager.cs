using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class OptionUIManager : MonoBehaviour
{
    public GameObject startUI;
    public GameObject testUI;

    public GameObject personManager;
    public GameObject outsideSounds;

    public GameObject player;
    public Transform[] testStartObject;

    public GameObject omr;
    public GameObject descChoice;

    public PlayableDirector playableDirector;

    public GameObject aircon;
    public GameObject speaker;

    public void GameStart() //시험을 시작한다.
    {
        playableDirector.Play(); // 타임라인 시작
        Invoke("AfterStart", 2.5f);
        
    }

    public void BackButton() //시작 UI로 돌아간다.
    {
        startUI.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    void AfterStart()
    {
        aircon.GetComponent<AudioSource>().Play();
        speaker.GetComponent<AudioSource>().Play();
        personManager.SetActive(true); //학생, 소리 매니저를 활성화한다.
        outsideSounds.SetActive(true);

        int testPosition = descChoice.GetComponent<DeskChange>().NowDesk();
        switch (testPosition)
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


        testUI.SetActive(true);
        omr.SetActive(true);


        gameObject.transform.parent.gameObject.SetActive(false);
        return;
    }

}
