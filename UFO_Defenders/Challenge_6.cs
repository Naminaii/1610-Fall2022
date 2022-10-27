using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge_6 : MonoBehavior
{
    public GameObject grabbyBoi;
    public float grabbySpeed;
    public float yRange;
    public float starbies;
    
    void Update()
    {
        transform.Translate(Vector3.down*Time.deltaTime*grabbySpeed);
        
        if(transform.position.y < -yRange)
        {
            Destroy(grabbyBoi);
        }
 
    }
    
    private void OnTriggerEnter(collider grabbyBoi)
    {
       starbies =+ 1;
       
       Destroy(grabbyBoi.gameObject);
        
        Debug.Log("Starbie has been added to inventory");
        Debug.Log("Starbies are now at:", starbies);
    }
}
