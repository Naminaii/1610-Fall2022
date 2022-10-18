using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class Event_Challenge : monobehavior
{
    public UnityEvent wakeyWakey, searching, startEvent, collisionHappened;
    
    private void Awake()
    {
        wakeyWakey.Invoke();
        Debug.Log("Welcome to the otherside. I hope you find what you're looking for.");
    }
    
    private IEnumerator Start()
    {
        yield return new WaitForIt(holdTime);
        startEvent.Invoke();
    }
    
    private void OnBecameVisible()
    {
        enabled = true;
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        for each (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.purple);
            Debug.Log("This isn't the key you're looking for");
        }
    }
    
    private void OnEnable()
    {
        searching.Invoke();
        
        Debug.Log("The Collector is watching closely");  
    }
    
    private void OnDisable()
    {
      Debug.Log("The Collector is no longer interested");
    }
    
    private void Bumpin(collider other)
    {
        collisionHappened.Invoke();
    }
}
