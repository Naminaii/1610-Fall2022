using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehavior
{
    public bool isGameOver;
    private GameObject gameOverText;
    
    void Awake()
    {
        time.timescale = 1;
        isGameOver = false;
    }
    
    void Start()
    {
          gameOverText = GameObject.Find("GameOverText");
    }
    
    void Update()
    {
        if(isGameOver)
        {
            EndGame();
        }
        else
        {
            gameOverText.GameObject.setActive(false);
        }
        
        public void EndGame()
        {
            gameOverText.GameObject.setActive(true);
            Time.timeScale = 0;
        }
    }
}
