using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bla : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(
           /* X */ Input.GetAxis("Horizontal") * 5f * Time.deltaTime,
           /* Y */ Input.GetAxis("Vertical") * 5f * Time.deltaTime,
           /* Z */ 0f);


        transform.Translate(newPosition);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        Debug.Log("fashfsdhfkahsdk");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("fashfsdhfkahsdk");
    }
}
