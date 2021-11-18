using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text scoreText, goalText;
    public int goal;

    private int score;

    private void Start()
    {
        instance = this;
    }

    private void Update()
    {
        scoreText.text = "SCORE: " + score.ToString();
        goalText.text = "GOAL: " + goal.ToString();
    }

    public void AddScore(int amount)
    {
        score = score + amount;
    }
}
