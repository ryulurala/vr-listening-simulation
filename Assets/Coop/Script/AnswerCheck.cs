using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerCheck : MonoBehaviour
{
    public Sprite goodAnswer;
    public Sprite badAnswer;
    private Image image;

    // Start is called before the first frame update
    void Start()
    {
        image = gameObject.GetComponent<Image>();
    }

    public void GoodAnswer()
    {
        gameObject.GetComponent<Image>().sprite = goodAnswer;
    }

    public void BadAnswer()
    {
        gameObject.GetComponent<Image>().sprite = badAnswer;
    }
}
