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
    
    public void createInstance(Vector3DataList obj)
    {
       for(var i = 0; i < Vector#DataList.Count; i++)
       {
       Instantiate(prefab, obj.Vector3DataList[i].value, Quanternion.identity);
       }
    }
}
