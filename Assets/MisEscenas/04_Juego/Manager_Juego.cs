using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager_Juego : MonoBehaviour
{
    GameObject panel_GameOver;
    GameObject topScore;
    GameObject score;
    GameObject time;

    float timeCount;
    int scoreCount;


    // Start is called before the first frame update
    void Start()
    {
        panel_GameOver = GameObject.Find("Panel_GameOver");
        topScore = GameObject.Find("Text_GameOver");
        score = GameObject.Find("Text_Score");
        time = GameObject.Find("Text_Time");

        DeactivatePanelGameOver();

        timeCount = 0f;
        scoreCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        UpdateTimeLabel((int)timeCount);
    }


    private void UpdateTimeLabel(int seconds)
    {
        this.time.GetComponent<Text>().text = $"Tiempo: {seconds}";
    }

    public void GoToMenuScene()
    {
        SceneManager.LoadScene(WellKnown.Scenes.Menu);
    }

    public void GoToJuegoScene()
    {
        SceneManager.LoadScene(WellKnown.Scenes.Juego);
    }

    public void ActivatePanelGameOver()
    {
        this.panel_GameOver.SetActive(true);
    }

    public void DeactivatePanelGameOver()
    {
        this.panel_GameOver.SetActive(false);
    }

    public void ChageGameOverTopScore(string topScore)
    {
        this.topScore.GetComponent<Text>().text = topScore;
    }

    public void AddToScore(int addToScore)
    {
        this.scoreCount += addToScore;
        this.score.GetComponent<Text>().text = scoreCount.ToString();
    }
}
