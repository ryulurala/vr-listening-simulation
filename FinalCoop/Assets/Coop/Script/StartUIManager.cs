using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUIManager : MonoBehaviour
{
    public GameObject optionUI;

    public void StartButton()
    {
        optionUI.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

    public void EndButton()
    {

    }
}
