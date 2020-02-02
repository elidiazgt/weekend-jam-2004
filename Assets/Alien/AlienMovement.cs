using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienMovement : MonoBehaviour
{

    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f;
    private float characterVelocity = 2f;
    private Vector2 movementDirection;
    private Vector2 movementPerSecond;
    public GameObject alien;

    void Start() {
        latestDirectionChangeTime = 0f;
        calcuateNewMovementVector();
      
    }

    void calcuateNewMovementVector() {
        //create a random direction vector with the magnitude of 1, later multiply it with the velocity of the enemy
        //movementDirection = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)).normalized;
        movementDirection = new Vector2(
            Mathf.Clamp( Random.Range(-1.0f, 1.0f), -10f, 10f)
            , 0);
        movementPerSecond = movementDirection * characterVelocity;
    }

    void Update() {
        //if the changeTime was reached, calculate a new movement vector
        if (Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calcuateNewMovementVector();
        }

        var random = Time.deltaTime % 1000;

        if (random > 0.04 && random < 0.05)
        {   
            alien.GetComponent<Alien>().shoot();
        }

        //move enemy:
        var position_x = transform.position.x + (movementPerSecond.x * Time.deltaTime);

        if (transform.position.x < -8) {

            position_x = position_x * 1;
        }

        if (transform.position.x > 8)
        {

            position_x = position_x * %-1;
        }

        transform.position = new Vector2(position_x,
        transform.position.y + (movementPerSecond.y * Time.deltaTime));

    }
}
