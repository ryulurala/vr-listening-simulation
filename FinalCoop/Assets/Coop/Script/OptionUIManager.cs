using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionUIManager : MonoBehaviour
{
    public GameObject startUI;

    public void GameStart()
    {
        
    }

    public void BackButton()
    {
        startUI.SetActive(true);
        gameObject.transform.parent.gameObject.SetActive(false);
    }

}
