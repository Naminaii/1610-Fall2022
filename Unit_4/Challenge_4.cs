uisng Systems.Collections;
using Systems.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
[RequireComponent(typeof(text))]

public class Challenge_4 : ScriptableObject
{
    public Text label;
    public FloatData dataObj;
    
    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }
    
    public void UpdateLabel()
    {
        lable.txt = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
    public UnityEvent onZeroEvent;
   
   public float Value; 
   
   public void UpdateValue(float num)
   {
       if(value <= 0)
        {
            public UnityEvent onZeroEvent;
             
            value =+ num;
        } 
        else if(value <= 1)
        {
            value = 1;
        }
        
        img.fillAmount = value;
    } 
   }
   
    public void displayNumber(Text txt)
    {
        txt.text = value.ToString();
    }
    
     public void Print()
    {
        Debug.Log("Hello" + label + txt);
    }
}
