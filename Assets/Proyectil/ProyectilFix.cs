using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilFix : MonoBehaviour
{
    float timeCount = 0f;

    void Update() {
        timeCount += Time.deltaTime;

        // despues de 1.5 segundos de vida, destruir proyectil
        if (timeCount > 1.0f)
        {
            Destroy(gameObject);
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision) {
    //    //if ((collision.name.Contains("fixer") == false))
    //    //{
    //    //    Destroy(gameObject);
    //    //}
    //}
}
