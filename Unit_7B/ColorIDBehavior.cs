using UnityEngine;

public class ColorIDBehavior : ID
{
    public ColorIDDataList colorIDDataListObj;
    
    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }
}
