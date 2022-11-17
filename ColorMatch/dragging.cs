using Systems.Collections;
using UnityEngine;
using UnityEvents;

public class dragging : MonoBehaviour
{
    private Camera cameraObj;
    public bool Draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent;
    
    private void Start()
    {
        cameraObj = Camera.main;
    }
    
    public IEnumerator OnMouseDown()
    {
        offset = transform.position - cameraObj.ScreenToWorldPoint(Input.mousePosition);
        Draggable = true;
        startDragEvent.Invoke();
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
        endDragEvent.Invoke();
    }
}
