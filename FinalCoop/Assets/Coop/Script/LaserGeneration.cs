using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
using UnityEngine.UI;

public class LaserGeneration : MonoBehaviour
{
    public SteamVR_Input_Sources handType; //왼손 오른손
    public SteamVR_Behaviour_Pose controllerPose; //
    public SteamVR_Action_Boolean TriggerCheck; //트리거 버튼 
    public SteamVR_Action_Boolean TouchPadTouch; //터치패트 터치

    public GameObject laserPrefab; //레이저 프리팹
    private GameObject laser; //레이저(내부 사용 오브젝트)
    private Transform laserTransform; //레이저 트랜스폼
    private Vector3 hitPoint; //레이캐스트 충돌 지점

    // Start is called before the first frame update
    void Start() //레이저 프리팹 가져오기
    {
        laser = Instantiate(laserPrefab);
        laserTransform = laser.transform;

    }

    // Update is called once per frame
    void Update()
    {
        if (TouchPadTouch.GetState(handType)) //왼손 혹은 오른손에서 터치 패드를 터치하고 있는지 확인
        {
            RaycastHit hit;
            Debug.Log("dd");
            if (Physics.Raycast(controllerPose.transform.position, transform.forward, out hit)) //레이캐스트 확인
            {
                hitPoint = hit.point; //레이캐스트가 닿은 곳을 파악
                ShowLaser(hit); //레이저 생성

                if(TriggerCheck.GetState(handType)) //트리거를 누르면 실행
                {
                    hit.transform.GetComponent<ButtonClick>().OnClick();
                }
            }
            else
                laser.SetActive(false);
        }
        else //트리거 버튼이 눌려있지 않으면 레이저 비활성화
            laser.SetActive(false); 
    }

    private void ShowLaser(RaycastHit hit) //레이저 생성 함수
    {
        laser.SetActive(true);
        laser.transform.position = Vector3.Lerp(controllerPose.transform.position, hitPoint, 0.5f);
        laserTransform.LookAt(hitPoint);
        laserTransform.localScale = new Vector3(laserTransform.localScale.x, laserTransform.localScale.y, hit.distance);
    }
}
