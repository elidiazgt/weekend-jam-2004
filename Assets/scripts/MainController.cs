using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainController : MonoBehaviour
{
    public Notifications notifications ;
    public List<GameObject> buildings;
    public TextMeshProUGUI general_score;

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
        general_score.text = "Score: ";//+ Time.deltaTime + "% #2" + "";
        var i = 0;
        foreach (var item in buildings)
        {
            i++;
            general_score.text += "  #" + i + " " + item.GetComponent<Edificio>().vida;
        }
    }
}
