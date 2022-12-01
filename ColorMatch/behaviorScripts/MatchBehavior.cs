using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchBehavior : MonoBehavior
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchDelay;
    
    private IEnumerator OnTriggerEnter(collider other)
    {
       var tempObj = other.GetComponent<IDContainer>();
        if(tempObj != null) 
            yield break;
       
       var otherID = tempObj.idObj;  
       if (otherID == idObj)
       {
           matchEvent.Invoke();
        }
        else
            {
                noMatchEvent.Invoke();
                yield return new WaitForSeconds(0.5f);
                Destroy(gameObject);
                Destroy(other.gameObject);
                noMatchDelay.Invoke();
            }
    }
}
