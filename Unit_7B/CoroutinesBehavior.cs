using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesBehavior : MonoBehaviour
{
    public bool canRun = true;
    
    IEnumerator Start()
    {
        Debug.Log("Start");
        yeild return new WaitForSeconds(3);
        Debug.Log("Late Start");
        
        while(canRun)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Run on start");
        }
    }
    
    void Update()
    {
        Debug.Log("Run");
    }
}
