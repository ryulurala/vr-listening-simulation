using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class ActionTest : MonoBehaviour
{
    public SteamVR_Input_Sources handType;  // 모두 사용, 왼손, 오른손
    public SteamVR_Behaviour_Pose controllerPose;   // 컨트롤러 정보
    public SteamVR_Action_Boolean grabAction;   // 그랩 액션

    private GameObject collidingObject;     // 현재 충돌 중인 객체
    private GameObject ObjectInHand;    // 플레이어가 잡은 객체

    void Update()
    {
        // 잡는 버튼을 누를 때
        if (grabAction.GetLastStateDown(handType))
        {
            if (collidingObject)
            {
                GrabObject();
            }
        }

        // 잡는 버튼을 땔 때
        if (grabAction.GetLastStateUp(handType))
        {
            if (ObjectInHand)
            {
                ReleaseObject();
            }
        }
    }

    // 충돌이 시작되는 순간
    public void OnTriggerEnter(Collider other)
    {
        SetCollidingObject(other);
    }

    // 충돌 중일 때
    public void OnTriggerStay(Collider other)
    {
        SetCollidingObject(other);
    }

    // 충돌이 끝나는 순간
    public void OnTriggerExit(Collider other)
    {
        if (!collidingObject)
        {
            return;
        }
        collidingObject = null;
    }

    private void SetCollidingObject(Collider col)
    {
        if (collidingObject || !col.GetComponent<Rigidbody>())
        {
            return;
        }
        collidingObject = col.gameObject;
    }

    // 객체를 잡음
    private void GrabObject()
    {
        ObjectInHand = collidingObject; // 잡은 객체로 설정
        collidingObject = null; // 충돌 객체 해제

        var joint = AddFixedJoint();
        joint.connectedBody = ObjectInHand.GetComponent<Rigidbody>();
    }

    // FixedJoint => 객체들을 하나로 묶어 고정시켜줌
    // breakForce => 조인트가 제거되도록 하기 위한 필요한 힘의 크기
    // breakTorque => 조인트가 제거되도록 하기 위한 필요한 토크
    private FixedJoint AddFixedJoint()
    {
        FixedJoint fx = gameObject.AddComponent<FixedJoint>();
        fx.breakForce = 20000;
        fx.breakTorque = 20000;
        return fx;
    }

    // 객체를 놓음
    // controllerPose.GetVeloecity() => 컨트롤러의 속도
    // controllerPose.GetAngularVelocity() => 컨트롤러의 각속도

    private void ReleaseObject()
    {
        if (GetComponent<FixedJoint>())
        {
            GetComponent<FixedJoint>().connectedBody = null;
            Destroy((GetComponent<FixedJoint>()));

            ObjectInHand.GetComponent<Rigidbody>().velocity = controllerPose.GetVelocity();
            ObjectInHand.GetComponent<Rigidbody>().angularVelocity = controllerPose.GetAngularVelocity();
        }
        ObjectInHand = null;
    }
}
