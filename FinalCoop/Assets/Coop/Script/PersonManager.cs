using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    public GameObject[] students;

    private bool initializeCheck;

    // Start is called before the first frame update
    void Start()
    {
        initializeCheck = false;
        for (int i = 0; i < students.Length; i++)
        {
            students[i].GetComponent<StudentControl>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!initializeCheck)
        {
            StartCoroutine(SetSitState());
        }
    }

    IEnumerator SetSitState()
    {
        Debug.Log("Initialize");
        initializeCheck = true;

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i].GetComponent<Animator>().GetInteger("Sit_State") != 0)
            {
                students[i].GetComponent<Animator>().SetInteger("Sit_State", 0);
            }
        }

        yield return new WaitForSeconds(3.0f);

        initializeCheck = false;
    }

}
