using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskChange : MonoBehaviour
{
    int nowDesk;

    public void CheckDesk(string checkToggle)
    {
        switch (checkToggle)
        {
            case "Desk11":
                nowDesk = 11;
                break;
            case "Desk12":
                nowDesk = 12;
                break;
            case "Desk13":
                nowDesk = 13;
                break;
            case "Desk14":
                nowDesk = 14;
                break;
            case "Desk21":
                nowDesk = 21;
                break;
            case "Desk22":
                nowDesk = 22;
                break;
            case "Desk23":
                nowDesk = 23;
                break;
            case "Desk24":
                nowDesk = 24;
                break;
            case "Desk31":
                nowDesk = 31;
                break;
            case "Desk32":
                nowDesk = 32;
                break;
            case "Desk33":
                nowDesk = 33;
                break;
            case "Desk34":
                nowDesk = 34;
                break;
            case "Desk41":
                nowDesk = 41;
                break;
            case "Desk42":
                nowDesk = 42;
                break;
            case "Desk43":
                nowDesk = 43;
                break;
            case "Desk44":
                nowDesk = 44;
                break;
            case "Desk51":
                nowDesk = 51;
                break;
            case "Desk52":
                nowDesk = 52;
                break;
            case "Desk53":
                nowDesk = 53;
                break;
            case "Desk54":
                nowDesk = 54;
                break;
        }
    }

    public int NowDesk()
    {
        return nowDesk;
    }
}
