using Systems.Collections;
using UnityEngine;
using UnityEvents;

public class Movement : MonoBehaviour
{
    private Camera cameraObj;
    public bool Draggable;
    public Vector3 position, offset;
    public UnityEvent startDragEvent, endDragEvent, matchEvent, noMatchEvent, noMatchDelay;
    public ID idObj;
    
    private void Start()
    {
        cameraObj = Camera.main;
    }
    
    private IEnumerator OnTriggerEnter(collider other)
    {
       var tempObj = other.GetComponent<IDContainer>();
        if(tempObj != null) 
            yield break;
       
       var otherID = tempObj.idObj;  
       if (otherID == idObj)
       {
           matchEvent.Invoke();
        }
        else
            {
                noMatchEvent.Invoke();
                yield return new WaitForSeconds(0.5f);
                noMatchDelay.Invoke();
            }
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
