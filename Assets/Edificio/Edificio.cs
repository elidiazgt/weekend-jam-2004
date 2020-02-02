<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificio : MonoBehaviour
{
    GameObject imagen1_Casa_100;
    GameObject imagen2_Casa_50;
    GameObject imagen3_Casa_0;

    public int vida;

    void Start()
    {
        vida = 100;

        //imagen1_Casa_100 = GameObject.Find("Edificio_1_300x300");
        imagen1_Casa_100 = gameObject.transform.Find("Edificio_1_300x300").gameObject;
        imagen2_Casa_50 = gameObject.transform.Find("Edificio_2_300x300").gameObject;
        imagen3_Casa_0 = gameObject.transform.Find("Edificio_3_300x300").gameObject;

        imagen1_Casa_100.SetActive(false);
        imagen2_Casa_50.SetActive(false);
        imagen3_Casa_0.SetActive(false);

    }


    void Update()
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edificio : MonoBehaviour
{
    GameObject imagen1_Casa_100;
    GameObject imagen2_Casa_50;
    GameObject imagen3_Casa_0;

    public int vida;

    void Start()
    {
        vida = 100;

        //imagen1_Casa_100 = GameObject.Find("Edificio_1_300x300");
        imagen1_Casa_100 = gameObject.transform.Find("Edificio_1_300x300").gameObject;
        imagen2_Casa_50 = gameObject.transform.Find("Edificio_2_300x300").gameObject;
        imagen3_Casa_0 = gameObject.transform.Find("Edificio_3_300x300").gameObject;

        imagen1_Casa_100.SetActive(false);
        imagen2_Casa_50.SetActive(false);
        imagen3_Casa_0.SetActive(false);

    }


    void Update()
>>>>>>> ebde9580609037329bc2bd16f954f0e6fee17a61
    {

        // vida entre 0 y 10
        if (vida < 10)
        {
            imagen1_Casa_100.SetActive(false);
            imagen2_Casa_50.SetActive(false);
            imagen3_Casa_0.SetActive(true);
        }

        // vida entre 10 y 90
        else if ((vida >=10) && (vida <= 90))
        {
            imagen1_Casa_100.SetActive(false);
            imagen2_Casa_50.SetActive(true);
            imagen3_Casa_0.SetActive(false);
        }

        // vida entre 90 y 100
        else if (vida > 90)
        {
            imagen1_Casa_100.SetActive(true);
            imagen2_Casa_50.SetActive(false);
            imagen3_Casa_0.SetActive(false);
        }

<<<<<<< HEAD
    }

    public void take_damage() {

        vida = vida - 10;

       

    }

    public void repair_damage() {

        vida = vida + 5;
    }

=======
    }


>>>>>>> ebde9580609037329bc2bd16f954f0e6fee17a61
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Proyectil"))
        {
            vida -= 10;
        }
        
<<<<<<< HEAD
    }

}
=======
    }

}
>>>>>>> ebde9580609037329bc2bd16f954f0e6fee17a61
