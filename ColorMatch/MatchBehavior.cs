using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchBehavior : MonoBehavior
{
    public ID idObj;
    
    private void OnTriggerEnter(collider other)
    {
        var otherID = other.GetComponent<IDContainer>().idObj;
        
        if (otherID == idObj)
        {
            Debug.Log("Match");
        }
    }
}
