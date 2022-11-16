using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]

public class spriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    
    private void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }
    
    public void ChangeRendererColor(Color color)
    {
        rendererObj.color = color;
        
    }
}
