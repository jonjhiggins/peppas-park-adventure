using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 0;
    public TextMeshProUGUI scoreText;

    void Start()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.SetText(score.ToString());
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    public void DecreaseScore(int amount)
    {
        score -= amount;
        UpdateScoreText();
    }

}
