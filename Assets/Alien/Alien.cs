using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public GameObject proyectil;
<<<<<<< HEAD
    private float x_position = 0;


=======

    
>>>>>>> ebde9580609037329bc2bd16f954f0e6fee17a61
    void Start()
    {
        
    }

    
    void Update()
    {
        Test_Mover();
<<<<<<< HEAD
        if (Input.GetKeyDown("2"))
=======
        if (Input.GetKeyDown("p"))
>>>>>>> ebde9580609037329bc2bd16f954f0e6fee17a61
        {
            Test_Disparar();
        }

        
    }

    void Test_Mover()
    {
<<<<<<< HEAD

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
        if(x_position > 8 || x_position < -8)
        {
            x_position = 0;
        }
=======
        Vector3 newPosition = new Vector3(
           /* X */ Input.GetAxis("Horizontal") * 5 * Time.deltaTime,
           /* Y */ Input.GetAxis("Vertical") * 5 * Time.deltaTime,
           /* Z */ 0f);

>>>>>>> ebde9580609037329bc2bd16f954f0e6fee17a61
        transform.Translate(newPosition);
    }

    void Test_Disparar()
    {
        Instantiate(proyectil, transform.position, transform.rotation);
    }
}
