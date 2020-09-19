using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonManager : MonoBehaviour
{
    public List<GameObject> students = new List<GameObject>();

    private bool initializeCheck;

    // Start is called before the first frame update
    void OnEnable()
    {
        // 게임 종료 후에 클리어후 다시 실행
        students.AddRange(GameObject.FindGameObjectsWithTag("Student"));

        initializeCheck = false;
        for (int i = 0; i < students.Count; i++)
        {
            students[i].GetComponent<StudentControl>().enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!initializeCheck)
        {
            StartCoroutine(SetInitState());
        }
    }

    void RandomSeat()
    {
        int swap1, swap2;
        Vector3 temp = new Vector3(0, 0, 0);
        for (int i = 0; i < 10; i++)
        {
            swap1 = Random.Range(0, 20);
            swap2 = Random.Range(0, 20);
            temp = students[swap1].transform.position;
            students[swap1].transform.position = students[swap2].transform.position;
            students[swap2].transform.position = temp;
        }
    }

    IEnumerator SetInitState()
    {
        Debug.Log("Initialize");
        initializeCheck = true;

        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].GetComponent<Animator>().GetInteger("Sit_State") != 0)
            {
                students[i].GetComponent<Animator>().SetInteger("Sit_State", 0);
            }
        }

        yield return new WaitForSeconds(10.0f);

        initializeCheck = false;
    }

}