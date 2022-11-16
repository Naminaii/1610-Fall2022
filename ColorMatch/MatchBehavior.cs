using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehavior
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;
    
    private void OnTriggerEnter(collider other)
    {
       var tempObj = other.GetComponent<IDContainer>();
        if(tempObj != null) 
            return;
       
       var otherID = tempObj.idObj;  
       if (otherID == idObj)
       {
           matchEvent.Invoke();
        }
        else
            {
                noMatchEvent.Invoke();
            }
    }
}
