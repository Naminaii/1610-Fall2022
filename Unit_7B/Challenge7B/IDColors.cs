using UnityEngine;

[CreateAssetMenu]

public class ID : ScriptableObject
{
    public ID idObj;
    public ColorIDDataList colorIDDataListObj;
    public ColorID currentColor;
    private int num;
    public UnityEvent startEvent;
    
    private void Start()
    {
        idObj = colorIDDataListObj.currentColor;
        startEvent.Invoke();
    }
    
    public void startRendererColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }
    
    public void changeColor(SpriteRenderer renderer)
    {
       public var newColor = idObj as ColorID;
       renderer.Color = newColor.value;
    }
   
   public void SetCurrentColorRando()
    {
        num = ColorID.Count -1;
        currentColor = ColorID[num];
    }
}
