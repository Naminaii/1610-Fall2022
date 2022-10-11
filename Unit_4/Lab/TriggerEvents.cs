using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : monobehavior
{
    public UnityEvent triggerEnterEvent;
    
    private void OnTriggerEnter(collider other)
    {
        triggerEnterEvent.invoke();
    }
}
