using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class instancer : ScriptableObject
{
    public GameObject prefab;
    private int numb = 0;
    
    public void createInstance()
    {
        Instantiate(prefab);
    }
    
    public void createInstanceFromList(vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quanternion.identity);
    }
    
    public void createInstanceCounting(Vector3DataList obj)
    {
       foreach(var i = 0; i < Vector#DataList.Count; i++)
       {
       Instantiate(prefab, obj.Vector3DataList[i].value, Quanternion.identity);
       }
    }
    
    public void createInstanceCounting(Vector3DataList obj)
    {
       numb = obj.Vector3DataList.Count;
       numb--;
       Instantiate(prefab, obj.Vector3DataList[i].numb.value, Quanternion.identity);
    }
}
