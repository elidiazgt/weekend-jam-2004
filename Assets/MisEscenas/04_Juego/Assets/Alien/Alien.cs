using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    List<GameObject> pathPoints = new List<GameObject>();
    int pathPoints_Counter = 0;

    public GameObject proyectil;

    void Start()
    {
        pathPoints.Add(GameObject.Find("PathHead"));
        pathPoints.Add(GameObject.Find("PathTail"));
    }


    void Update()
    {
        FollowPath(2f);

        RandomShoot();
    }



    void FollowPath(float Velocidad)
    {
        // Mientras no llegue a la distancia 0.5, seguir caminando, si no, cambiar de pocicio
        if (Vector3.Distance(pathPoints[pathPoints_Counter].transform.position, this.transform.position) > 0.5)
        {
            transform.position = Vector3.MoveTowards(transform.position, pathPoints[pathPoints_Counter].transform.position, Time.deltaTime * Velocidad);
        }
        else if (pathPoints_Counter < pathPoints.Count - 1)
        {
            pathPoints_Counter++;
        }
        else
        {
            // En caso que se termine el loop, aqui lo reinicio mandando el objeto al punto 0
            pathPoints_Counter = 0;
        }
    }


    float timeCount = 0f;
    void RandomShoot()
    {
        timeCount += Time.deltaTime;

        if(timeCount > 1f)
        {
            int result = Random.Range(0, 2);
            if(result == 1)
            {
                // shoot
                var nuevoProyectil = Instantiate(proyectil, transform.position, transform.rotation);
                nuevoProyectil.GetComponent<Rigidbody2D>().velocity = Vector2.down * 4.2f;
            }
            timeCount = 0f;
        }
    }

    
}
