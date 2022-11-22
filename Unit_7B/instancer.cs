using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class instancer : ScriptableObject
{
    public GameObject prefab;
    
    public void createInstance()
    {
        Instantiate(prefab);
    }
    
    public void createInstance(vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quanternion.identity);
    }
}
