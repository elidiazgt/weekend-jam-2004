using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public GameObject proyectil;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        Test_Mover();
        if (Input.GetKeyDown("p"))
        {
            Test_Disparar();
        }

        
    }

    void Test_Mover()
    {
        Vector3 newPosition = new Vector3(
           /* X */ Input.GetAxis("Horizontal") * 5 * Time.deltaTime,
           /* Y */ Input.GetAxis("Vertical") * 5 * Time.deltaTime,
           /* Z */ 0f);

        transform.Translate(newPosition);
    }

    void Test_Disparar()
    {
        Instantiate(proyectil, transform.position, transform.rotation);
    }
}
