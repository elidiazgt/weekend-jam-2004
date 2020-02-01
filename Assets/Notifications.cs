using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notifications : MonoBehaviour
{
    public Marquee marquee;

    public List<String> new_news() {
        List<String> new_list = new List<String>();
        new_list.Add("Mensaje 1");
        new_list.Add("Mensaje 2");

        return new_list;
    }

    public void cambiarTextoMarquee(string rtext)
    {
        marquee.message = rtext;
    }

    
}
