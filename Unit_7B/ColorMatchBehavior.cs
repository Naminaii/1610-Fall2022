using UnityEngine;

public class ColorMatchBehavior : MatchBehavior
{
    public ColorIDDataList colorIDDataListObj;
    
    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
