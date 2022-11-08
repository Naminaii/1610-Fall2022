using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOUtOfBounds : MonoBehavior
{
    public float topBounds = 30f;
    public float bottomBounds = -10f;
    
    void awake()
    {
        Time.timeScale = 1;
    }
    
    void Update()
    {
        if(transform.position.z > topBounds)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomBounds)
        {
            Debug.Log("Game Over. Everyone is dead.");
            Destroy(gameObject);
        }
    }
}
