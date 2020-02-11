using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager_Menu : MonoBehaviour
{

    public void GoToGameScene()
    {
        SceneManager.LoadScene(WellKnown.Scenes.Juego);
    }

    public void GoToAboutScene()
    {
        SceneManager.LoadScene(WellKnown.Scenes.About);
    }
}