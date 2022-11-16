using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehavior : MonoBehavior
{
    public ID idObj;
    
    private void OnTriggerEnter(collider other)
    {
       var tempObj = other.GetComponent<IDContainer>();
        if(tempObj != null) 
            return;
           var otherID = tempObj.idObj; 
            
       if (otherID == idObj)
       {
           Debug.Log("Match");
        }
        else
            {
                Debug.Log("Not A Match :(");
            }
    }
}
