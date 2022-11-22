using System.Collections.Generic;
using UnityEngine;

public class destroyBehavior : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wfsObj;
    
    private IEnumerator Start()
    {
        wfsObj = new WaitForSeconds(seconds);
        Destroy(GameObject);
    }
}
