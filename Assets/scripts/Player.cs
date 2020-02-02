using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MainController.Instance.notifications.cambiarTextoMarquee("CAMBIE DE NUEVO");
    }

    // Update is called once per frame
    void Update()
    {
        // detect position

        Vector3 newPosition = new Vector3(
           /* X */ Input.GetAxis("Horizontal") * 5 * Time.deltaTime,
           /* Y */ Input.GetAxis("Vertical") * 5 * Time.deltaTime,
           /* Z */ 0f);



        transform.Translate(newPosition);

        // detect fire

        if (Input.GetKeyDown("space")) {

            var buildings = MainController.Instance.buildings;
            int i = 0;
            foreach (var building in buildings)
            {
                i++;
                if (transform.position.x >= building.transform.position.x
                    || transform.position.x <= building.transform.position.x + 30) {
                    Debug.Log("Estoy dentro del edificio  " + i);
                    Debug.Log("transform.position.x"+ transform.position.x);
                    Debug.Log("building.transform.position.x" + i + " -" + building.transform.position.x);

                }


                //Debug.Log("building: "+ i +" - " + item.transform.position.x);
                //Debug.Log("Player X: " + transform.position.x);

            }

        }



    }

    void use_tool()
    {
        // what building to repair?
        GameObject building = detect_building();

        if (building != null ) {
            building.GetComponent<Edificio>().take_damage();


        }

    }

    GameObject detect_building()
    {



        return null;



    }

    void where_is_tool()
    {

    }
}
