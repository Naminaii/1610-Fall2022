using UnityEngine;

[CreateAssetMenu]

public class ID : ScriptableObject
{
    public ID idObj;
    public UnityEvent startEvent;
    
    private void Start()
    {
        startEvent.Invoke();
    }
    
    public void startRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }
}
