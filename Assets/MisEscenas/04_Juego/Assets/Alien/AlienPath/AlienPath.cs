using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienPath : MonoBehaviour
{

    float screenHeight;
    float screenWidth;

    GameObject pathHead;
    GameObject pathTail;

    void Start()
    {
        // Calculate units of screen width and height
        screenHeight = 2 * Camera.main.orthographicSize;
        screenWidth = screenHeight * Camera.main.aspect;

        pathHead = GameObject.Find("PathHead");
        pathTail = GameObject.Find("PathTail");

        pathHead.transform.position = new Vector3(
            -(screenWidth / 2f) + 1,// X
            (screenHeight / 2f) - 2,// Y
            -2f// Z
            );

        pathTail.transform.position = new Vector3(
            (screenWidth / 2f) - 1,// X
            (screenHeight / 2f) - 2,// Y
            -2f// Z
            );
    }
}
