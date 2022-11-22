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
    
    public void compareValue(scoreKeep obj)
    {
        if(value =< obj.value)
        {
            
        }
        else
        {
            value = obj.value;
        }
        
        if (otherID == idObj)
        {
           matchEvent.Invoke();
        }
        else
            {
                noMatchEvent.Invoke();
                yield return new WaitForSeconds(0.5f);
                noMatchDelay.Invoke();
            }
       }
    }
