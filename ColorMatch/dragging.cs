using UnityEngine;

public class dragging : MonoBehaviour
{
    private Camera cameraObj;
    public bool Draggable;
    public Vector3 position, offset;
    
    private void Start()
    {
        cameraObj = Camera.main;
    }
    
    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        Draggable = true;
        yield return new WaitForFixedUpdate();
        
        while(Draggable = true)
        {
          yield return new WaitForFixedUpdate();
          position = cameraObj.ScreenToWorldPoint(Input.mousePosition) + offset;
          transform.position = position;
        }
    }
    
    private OnMouseUp()
    {
        Draggable = false;
    }
}
