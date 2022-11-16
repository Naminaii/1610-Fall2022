using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreKeep : MonoBehaviour
{
    public int Score; //score value
    public TextMeshProUGUI scoreText; //displays the score

    public void increaseScore(int ammount)
    {
        Score += ammount;
        GetUpdateScoreText();
    }

    public void decreaseScore(int ammount)
    {
        Score -= ammount;
        GetUpdateScoreText();
    }

    public object GetUpdateScoreText() => Debug.Log(scoreText + Score);
}
