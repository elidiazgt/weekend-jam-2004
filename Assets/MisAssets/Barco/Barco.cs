using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barco : MonoBehaviour
{
    public GameObject ola;
    public float pos_y = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0f)
        {
            gameObject.transform.position = new Vector3(
                Mathf.Clamp(gameObject.transform.position.x + Input.GetAxis("Horizontal") / 2, -9, 9),
                ola.transform.position.y,
                gameObject.transform.position.z);
        }
    }
}
