using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvent : Monobehavior
{
    pubilc UnityEvent awakeEvent, startEvent, onEnableEvent;
    
    private void Awake()
    {
        awakeEvent.Invoke();
    }
    
    private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
        startEvent.Invoke();
    }
    
    private void onEnable()
    {
        onEnableEvent.Invoke();
    }
}
