using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HealthBar : MonoBehaviour
{

    public GUIStyle progress_empty;
    public GUIStyle progress_full;

    //current progress
    public float barDisplay;

    public Vector2 pos = new Vector2(10,10);


    public Vector2 size = new Vector2(300, 50);

    public Texture2D emptyTex;
    public Texture2D fullTex;

    void OnGUI()
    {
        //draw the background:
        GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y), emptyTex, progress_empty);

        GUI.Box(new Rect(pos.x, pos.y, size.x, size.y), fullTex, progress_full);

        //draw the filled-in part:
        GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
        GUI.Box(new Rect(0, 0, size.x, size.y), fullTex, progress_full);

        GUI.EndGroup();
        GUI.EndGroup();
    }

    void Update()
    {

        //the player's health
        barDisplay = this.GetComponent<Edificio>().vida / 100;
    }
    private void Start()
    {
        pos = new Vector2(transform.position.x + 30f, transform.position.y + 40f);
        
    }
}