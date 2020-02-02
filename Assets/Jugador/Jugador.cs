﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{

    public float velocidad_Mov_X = 5f;
    public float velocidad_Mov_Y = 5f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(
            /* X */ Input.GetAxis("Horizontal") * velocidad_Mov_X * Time.deltaTime,
            /* Y */ Input.GetAxis("Vertical") * velocidad_Mov_Y * Time.deltaTime,
            /* Z */ 0f);


        transform.Translate(newPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        Debug.Log("jugador collision enter: " + collision.collider.name);
    }

    private void OnTriggerStay2D(Collider2D collision) {
        Debug.Log("player OnTriggerStay2D");
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("jugador trigger enter");
        if (collision.name.Contains("Proyectil"))
        {
            //vida -= 10;
        }
    }

    //private void OnCollisionStay2D(Collision2D collision) {
    //    Debug.Log("reparando: "+collision.collider.name);

    //    if (Input.GetKeyDown("space"))
    //    {
    //        //Debug.Log("reparando: "+collision.collider.name);
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision) {
    //    if (collision.name.Contains("Proyectil"))
    //    {
    //        vida -= 10;
    //    }
    //}


}
