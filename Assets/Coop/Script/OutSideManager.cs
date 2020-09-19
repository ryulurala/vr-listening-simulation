using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutSideManager : MonoBehaviour
{
    public GameObject bird;
    public GameObject car;

    [Header("WaitBirdDelaytime")]
    [SerializeField]
    private float birddelaytime;
    private bool birdCheck;

    [Header("WaitCarDelaytime")]
    [SerializeField]
    private float cardelaytime;
    private bool carCheck;

    // Start is called before the first frame update
    void Start()
    {
        birdCheck = false;
        carCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (SoundManager.soundManager.birdSpeed != 0)
        {
            if (!birdCheck)
            {
                StartCoroutine(BirdTwitter());
            }
        }
        if (SoundManager.soundManager.carHornSpeed != 0)
        {
            if (!carCheck)
            {
                StartCoroutine(CarHorn());
            }
        }
    }

    IEnumerator BirdTwitter()
    {
        birdCheck = true;

        switch (SoundManager.soundManager.birdSpeed)
        {
            case 1: // 적음
                birddelaytime = Random.Range(80, 200);
                break;
            case 2: // 많음
                birddelaytime = Random.Range(60, 120);
                break;
        }

        bird.GetComponent<SoundClip>().InputSound();
        bird.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(birddelaytime);

        birdCheck = false;
    }

    IEnumerator CarHorn()
    {
        carCheck = true;

        switch (SoundManager.soundManager.carHornSpeed)
        {
            case 1: // 적음
                cardelaytime = Random.Range(150, 300);
                break;
            case 2: // 많음
                cardelaytime = Random.Range(120, 180);
                break;
        }

        cardelaytime = Random.Range(4, 10);
        car.GetComponent<SoundClip>().InputSound();
        car.GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(cardelaytime);

        carCheck = false;
    }
}
