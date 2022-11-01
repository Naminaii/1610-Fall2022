using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge6B : MonoBehavior
{
    public gameObject[] powerUp;
    private float xBounds = 20f;
    private float birthInterval = 4f;
    public gameObject[] player
    
    public float deltaTime;
    public float speed;
    public float bottomBounds = -10f;
    
    void Update()
    {
        Vector3 spawnPos = new Vector3(Randomize.Range(-xBounds, xBounds, 0, 0);
        int infoIndex = Randomize.Range(0, powerUp.length); 
        Substantiate(powerUp[], spawnPos, powerUp[].transform.rotation);
        
       transform.Translate(Vector3.downard*Time.deltaTime*speed);
    }
    
    void OnTriggerEnter(collider player)
    {
        Destroy(gameObject);
        Debug.Log("You just got a power up. Good job.");
    }
}
