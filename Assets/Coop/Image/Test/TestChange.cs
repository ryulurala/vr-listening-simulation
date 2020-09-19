using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestChange : MonoBehaviour
{
    public Sprite[] questions;
    Image image;
    int nowQuestion;
    public void OnEnable()
    {
        image = gameObject.GetComponent<Image>();
        nowQuestion = 1;
        image.sprite = questions[nowQuestion];
    }

    public void BeforeQuestion()
    {
        if(nowQuestion != 1)
        {
            nowQuestion -= 1;
            image.sprite = questions[nowQuestion];

        }

    }

    public void AfterQuestion()
    {
        if(nowQuestion != 16)
        {
            nowQuestion += 1;
            image.sprite = questions[nowQuestion];
        }

    }
}
