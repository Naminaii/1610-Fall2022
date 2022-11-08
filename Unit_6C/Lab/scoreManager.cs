using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreManager : MonoBehavior
{
    public int Score; //score value
    public TextMeshProUGUI scoreText; //displays the score
    
    public void increaseScore(int ammount)
    {
        score += ammount;
        UpdateScoreText();
    }
    
    public void decreaseScore(int ammount)
    {
        score -= ammount;
        UpdateScoreText();
    }
    
    public void UpdateScoreText()
    {
        scoreText = "Score" + score;
    }
}
