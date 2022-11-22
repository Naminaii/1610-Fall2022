using UnityEngine;

[CreateAssetMenu]

public class colorIDList : ScriptableList
{
    public List<ColorID> colorIDList;
    
    public ColorID currentColor;
    private int num;
    
    private void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
    
    public void ChangeRendererColor(colorID obj)
    {
        rendererObj.color = obj.value;
        
    }
    
    public void ChangeRendereColor(ColorIDList obj)
    {
        rendererObj = obj.currentColor.value;
    }

    public void SetCurrentColorRando()
    {
        num = ColorID.Count -1;
        currentColor = ColorID[num];
    }
}
