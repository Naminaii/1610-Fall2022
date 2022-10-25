using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : monobehavior
{
    public float horizontalImput;
    public float speed;
    
    public float xRange;
    
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
    }
}
