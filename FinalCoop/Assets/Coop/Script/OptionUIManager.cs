using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void GameStart() //시험을 시작한다.
    {
        Invoke("AfterStart", 2.0f);
    }

    public void BackButton() //시작 UI로 돌아간다.
    {
        startUI.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    void AfterStart()
    {
        personManager.SetActive(true); //학생, 소리 매니저를 활성화한다.
        outsideSounds.SetActive(true);

        int testPosition = descChoice.GetComponent<DeskChange>().NowDesk();
        switch (testPosition)
        {
            case 11:
                player.transform.position = testStartObject[1].position;
                break;
            case 12:
                player.transform.position = testStartObject[2].position;
                break;
            case 13:
                player.transform.position = testStartObject[3].position;
                break;
            case 14:
                player.transform.position = testStartObject[4].position;
                break;
            case 21:
                player.transform.position = testStartObject[5].position;
                break;
            case 22:
                player.transform.position = testStartObject[6].position;
                break;
            case 23:
                player.transform.position = testStartObject[7].position;
                break;
            case 24:
                player.transform.position = testStartObject[8].position;
                break;
            case 31:
                player.transform.position = testStartObject[9].position;
                break;
            case 32:
                player.transform.position = testStartObject[10].position;
                break;
            case 33:
                player.transform.position = testStartObject[11].position;
                break;
            case 34:
                player.transform.position = testStartObject[12].position;
                break;
            case 41:
                player.transform.position = testStartObject[13].position;
                break;
            case 42:
                player.transform.position = testStartObject[14].position;
                break;
            case 43:
                player.transform.position = testStartObject[15].position;
                break;
            case 44:
                player.transform.position = testStartObject[16].position;
                break;
            case 51:
                player.transform.position = testStartObject[17].position;
                break;
            case 52:
                player.transform.position = testStartObject[18].position;
                break;
            case 53:
                player.transform.position = testStartObject[19].position;
                break;
            case 54:
                player.transform.position = testStartObject[20].position;
                break;

        }


        testUI.SetActive(true);
        omr.SetActive(true);


        gameObject.transform.parent.gameObject.SetActive(false);
        return;
    }

}
