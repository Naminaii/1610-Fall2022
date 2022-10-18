using UnityEngine;
using UnityEngine.Events;

public class Lab_Triggers : Monobehavior
{
    public UnityEvent triggerUnityEvent;
    
    private void OnTriggerCollider(Collider other)
    {
        trigerUnityEvent.invoke();
    }
}
