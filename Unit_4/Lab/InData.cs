using UnityEngine;
using UnityEngine.UI;

public class InData : ScriptableObject
{
    public int value;
    
    public void updateValue(int number)
    {
        value += number;
    }
    
    public void replaceValue(int number)
    {
        value = number;
    }
    
    public void imageDisplay(Image img)
    {
        img.fillAmount = value;
    }
    
    public void numberDisplay(Text txt)
    {
        txt.text = value.ToString();
    }
}
