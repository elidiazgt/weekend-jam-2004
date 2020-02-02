using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    private float velocidad_Mov_X = 5f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(
            /* X */ Input.GetAxis("Horizontal") * velocidad_Mov_X * Time.deltaTime,
            /* Y */ 0f,
            /* Z */ 0f);

        transform.Translate(newPosition);
    }
}
