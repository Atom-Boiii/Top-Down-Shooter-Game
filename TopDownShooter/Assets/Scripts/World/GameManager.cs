using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text scoreText, highScoreText;

    private int score;

    private void Start()
    {
        instance = this;
        highScoreText.text = PlayerPrefs.GetInt("High").ToString();
    }

    private void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
    }

    public void AddScore(int amount)
    {
        score = score + amount;
        int highScore = PlayerPrefs.GetInt("High");
        if(score > highScore)
        {
            PlayerPrefs.SetInt("High", score);
            highScoreText.text = PlayerPrefs.GetInt("High").ToString();
        }
    }

    public void OnRetry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void OnQuit()
    {
        Application.Quit();
    }
}
