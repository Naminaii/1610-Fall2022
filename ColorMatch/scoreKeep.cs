using UnityEngine;

[CreateAssetMenu]

public class scoreKeep : ScriptableObject
{
    public int value;
    
    public void UpdateValue(int num)
    {
        value += num;
    }
