using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehavior
{
    public int sceneToLoad;
    
    void Start()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    
    public void quitGame()
    {
        Application.Quit();
        Debug.Log("Quit Game.");
    }
}
