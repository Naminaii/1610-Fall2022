using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreKeep : MonoBehaviour
{
    public int value;
    
    public void UpdateValue(int num)
    {
        value += num;
    }
