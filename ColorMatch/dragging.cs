using UnityEngine;

public class dragging : MonoBehaviour
{
    private Camera cameraObj;
    public bool Draggable;
    public Vector3 position;
    
    private void Start()
    {
        cameraObj = Camera.main;
    }
    
    public IEnumerator OnMouseDown()
    {
        Draggable = true;
        while(Draggable = true)
        {
          yield return new WaitForFixedUpdate();
          position = cameraObj.ScreenToWorldPoint(Input.mousePosition);
          transform.position = position;
        }
    }
    
    private OnMouseUp()
    {
        Draggable = false;
    }
}
