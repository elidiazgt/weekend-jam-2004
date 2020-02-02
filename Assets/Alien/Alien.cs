using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public GameObject proyectil;

    private float x_position = 0;


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
         //x_position = 0;
        if (Input.GetKeyDown("1")) {

            x_position = x_position - 1;
        }

        if (Input.GetKeyDown("3"))
        {

            x_position = x_position + 1;
        }

        Debug.Log("x position" + x_position);

        Debug.Log(" Time.deltaTime" + Time.deltaTime);

        Vector3 newPosition = new Vector3(
           /* X */ x_position  * Time.deltaTime,
           /* Y */  0 * Time.deltaTime,
           /* Z */ 0f);
        //Vector3 newPosition = new Vector3(
        //   /* X */ Input.GetAxis("Horizontal") * 5 * Time.deltaTime,
        //   /* Y */ Input.GetAxis("Vertical") * 5 * Time.deltaTime,
        //   /* Z */ 0f);


        if (x_position > 8 || x_position < -8)
        {
            x_position = 0;
        }

        transform.Translate(newPosition);
    }

    void Test_Disparar()
    {
        Instantiate(proyectil, transform.position, transform.rotation);
    }
}
