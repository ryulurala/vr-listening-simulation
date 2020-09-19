using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskCheck : MonoBehaviour
{
    Toggle toggle;

    private void Start()
    {
        toggle = gameObject.GetComponent<Toggle>();
    }

    public void ToggleChange()
    {
        if(toggle.isOn)
        {
            transform.parent.GetComponent<DeskChange>().CheckDesk(gameObject.name);
        }
    }
}
