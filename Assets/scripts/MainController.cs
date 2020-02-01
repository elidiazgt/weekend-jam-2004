using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public Notifications notifications ;
    public List<GameObject> buildings;


    private static MainController _instance;

    public static MainController Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<MainController>();
            }

            return _instance;
        }
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }




    // Start is called before the first frame update
    void Start()
    {


     }

    // Update is called once per frame
    void Update()
    {

    }
}
