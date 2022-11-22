using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesBehavior : MonoBehaviour
{
    public bool canRun = true;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    
    IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFIxedUpdate();
        Debug.Log("Start");
        yeild return new wfsObj;
        Debug.Log("Late Start");
        
        while(canRun)
        {
            yield return wfsObj;
            Debug.Log("Run on start");
        }
    }
    
    void Update()
    {
        Debug.Log("Run");
    }
}
