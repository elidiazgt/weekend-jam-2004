using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class About_Manager : MonoBehaviour
{
    public void GoToMenuScene()
    {
        SceneManager.LoadScene(WellKnown.Scenes.Menu);
    }
}
