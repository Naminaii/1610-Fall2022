using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public ColorIDDataList colorIDDataListObj;
    
    
    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
    
    public void changeColor(SpriteRenderer renderer)
    {
       public var newColor = idObj as ColorID;
       renderer.Color = newColor.value;
    }
}
