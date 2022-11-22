using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class instancer : ScriptableObject
{
    public void createInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
