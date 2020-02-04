using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.0f;

    public bool isGrounded;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }


    void OnCollisionStay()
    {
        isGrounded = true;
    }

    private void OnTriggerStay(Collider collider)
    {
        if (collider.name.Contains("Wall"))
        {
            Debug.Log("1");
            if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.A))
            {
                rb.AddForce(-300, 300, 0);
                isGrounded = false;
                Debug.Log("2");
            }

            if (Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.D))
            {
                rb.AddForce(300, 300, 0);
                isGrounded = false;
                Debug.Log("3");
            }
        }
    }

    void Update()
    {


        MovePlayer();

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }


    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 5f * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 5f * Time.deltaTime);
        }
    }
}
