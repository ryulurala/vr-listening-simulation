using UnityEngine;
using Valve.VR;

/// <summary>
/// by 정민기, VR 컨트롤러 레이저 생성 스크립트
/// </summary>
public class LaserGeneration : MonoBehaviour
{
    public SteamVR_Input_Sources handType; // 왼손 오른손
    public SteamVR_Behaviour_Pose controllerPose; //
    public SteamVR_Action_Boolean TriggerCheck; // 트리거 버튼 
    public SteamVR_Action_Boolean TouchPadTouch; // 터치패트 터치

    public GameObject laserPrefab; // 레이저 프리팹
    private GameObject laser; // 레이저(내부 사용 오브젝트)
    private Transform laserTransform; // 레이저 트랜스폼
    private Vector3 hitPoint; // 레이캐스트 충돌 지점

    // Start is called before the first frame update
    void Start() // 게임 시작 시 laser 변수에 레이저 프리팹 할당
    {
        laser = Instantiate(laserPrefab);
        laserTransform = laser.transform;

    }

    // Update is called once per frame
    void Update()
    {
        // 트리거 버튼을 누르면 레이저 활성화
        if (TouchPadTouch.GetState(handType)) //왼손 혹은 오른손에서 터치 패드를 터치하고 있는지 확인
        {
            RaycastHit hit; // 레이캐스트에 닿은 오브젝트

            if (Physics.Raycast(controllerPose.transform.position, -transform.up, out hit)) //레이캐스트 확인
            {
                hitPoint = hit.point; //레이캐스트가 닿은 곳을 파악
                ShowLaser(hit); //레이저 생성

                if(TriggerCheck.GetState(handType) && hit.transform.tag != "LaserRed") //트리거를 누르면 실행
                {
                    hit.transform.GetComponent<ButtonClick>().OnClick(); // 레이캐스트에 닿은 버튼을 클릭
                }
            }
            else
                laser.SetActive(false);
        }
        else //트리거 버튼이 눌려있지 않으면 레이저 비활성화
            laser.SetActive(false); 
    }

    /// <summary>
    /// 레이저를 생성하는 함수
    /// </summary>
    /// <param name="hit">레이캐스트에 닿은 오브젝트</param>
    private void ShowLaser(RaycastHit hit) 
    {
        laser.SetActive(true); // 레이저 오브젝트 활성화
        
        if (hit.transform.tag == "LaserRed") //상호작용이 가능하면 빨간색 레이저 아니면 파란색 레이저
            laser.GetComponent<MeshRenderer>().material.color = Color.red;
        else
            laser.GetComponent<MeshRenderer>().material.color = Color.blue;

        laser.transform.position = Vector3.Lerp(controllerPose.transform.position, hitPoint, 0.5f); // 컨트롤러 위치로 레이저 오브젝트 위치 변경
        laserTransform.LookAt(hitPoint); // 레이캐스트에 닿은 오브젝트를 향하도록 레이저 오브젝트 회전

        // 레이캐스트에 닿은 오브젝트에 닿도록 레이저 오브젝트의 길이 늘리기
        laserTransform.localScale = new Vector3(laserTransform.localScale.x, laserTransform.localScale.y, hit.distance);
    }
}
