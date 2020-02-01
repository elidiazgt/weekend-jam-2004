using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Api : MonoBehaviour
{

    public IEnumerator getdata()
    {
        string RESTAPIURL = "http://pokeapi.co/api/v2/pokemon/25/";

        UnityWebRequest response = UnityWebRequest.Get(RESTAPIURL + "");

        Debug.Log("response: " + response);

        yield return response.SendWebRequest();

        Debug.Log("response END: " + response);
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("getdata");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
