using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehavior
{
    public float horizontalImput;
    public float speed = 25;
    public float xRange = 30;
    
    public Transform blaster;
    public GameObject lazerBolt;
    
    void update()
    {
        horizontalImput = Imput.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right*horizontalImput*Time.deltaTime);
        
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        if(transform.position.x > xRange)
        {
            transform.positon = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazerBolt, transform.positon, lazerbolt.transform.rotation);
        }
    }
}
