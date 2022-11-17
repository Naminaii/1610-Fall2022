using System;
using UnityEngine;
using UnityEvents;

[CreateAssetMenu]

public class scoreKeep : ScriptableObject
{
    public int value;
    public UnityEvent disableEvent;
    
    pubilic void Start(int num)
    {
        value = num;
    }
    
    public void setValue(IntData obj)
    {
        value = obj.value;
    }
    public void UpdateValue(int num)
    {
        value += num;
    }
    
    private void onDisable()
    {
        Debug.Log("End");
    }
}
