using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public UnityEvent onZeroEvent;
    
    public float value;
    
    public void ReplaceValue(float number)
    {
        value = number;
    }
    
    public void displayImage(Image img)
    {
        if(value <= 0)
        {
            onZeroEvent.invoke();
        } 
        else if(value <= 1)
        {
            value = 1;
        }
        
        img.fillAmount = value;
    }
    
    public void displayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
}
