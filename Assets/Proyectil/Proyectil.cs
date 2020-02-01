using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    float timeCount = 0f;


    void Start()
    {
        
    }


    void Update()
    {
        timeCount += Time.deltaTime;

        // despues de 1.5 segundos de vida, destruir proyectil
        if (timeCount> 1.5f)
        {
            Destroy(gameObject);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.name.Contains("Proyectil") == false))
        {
            Destroy(gameObject);
        }
    }

}
