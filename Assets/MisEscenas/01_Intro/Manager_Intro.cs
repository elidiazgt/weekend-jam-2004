using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_Intro : MonoBehaviour
{
    float waitTimeInSeconds;
    float timeCount;

    void Start()
    {
        waitTimeInSeconds = 2f;
        timeCount = 0f;
    }

    void Update()
    {
        timeCount += Time.deltaTime;

        if(timeCount > waitTimeInSeconds)
        {
            SceneManager.LoadScene(WellKnown.Scenes.Menu);
        }
    }
}
