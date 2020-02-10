using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fondo : MonoBehaviour
{
    void Start()
    {        
    }


    void Update()
    {
        gameObject.transform.Rotate(0f, 0f, 0.1f);
    }
}
