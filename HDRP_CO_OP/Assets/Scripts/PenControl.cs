using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenControl : MonoBehaviour
{
    Vector3 contect0;
    private void OnCollisionEnter(Collision collision)
    {
        contect0 = collision.contacts[0].point;
        
        // 소리 실행(종이든 땅이든 부딪히면)
         SoundManager.instance.PlaySE("First Dropping pen");
       
    }

    private void OnCollisionStay(Collision collision)
    {
       if(contect0 != collision.contacts[1].point)
       {
            SoundManager.instance.PlaySE("Other Dropping pen");
       }
    }

    private void OnTriggerEnter(Collider other)
    {
        /* 
        other이 종이면 글 쓰이게 구현
        if (other.transform.tag == "Paper")
        {
            // 글 쓰이게
            PaperControl에 bool 변수 true
        }
        */

    }
}
