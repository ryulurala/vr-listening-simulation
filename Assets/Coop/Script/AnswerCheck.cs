using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// by 정민기, 시험지 위의 채점 이미지를 활성화하는 클래스
/// </summary>
public class AnswerCheck : MonoBehaviour
{
    public Sprite goodAnswer; // O 이미지 sprite
    public Sprite badAnswer; // X 이미지 sprite
    private Image image; // sprite를 띄울 image 칸

    // 시험지 오브젝트가 활성화 될 때 호출, image 변수에 image 컴포넌트를 할당한다.
    void Start()
    {
        image = gameObject.GetComponent<Image>();
    }

    /// <summary>
    /// O(정답) 이미지 sprite를 image 컴포넌트에 집어넣는다.
    /// </summary>
    public void GoodAnswer()
    {
        gameObject.GetComponent<Image>().sprite = goodAnswer;
    }

    /// <summary>
    /// X(오답) 이미지 sprite를 image 컴포넌트에 집어넣는다. 
    /// </summary>
    public void BadAnswer()
    {
        gameObject.GetComponent<Image>().sprite = badAnswer;
    }
}
