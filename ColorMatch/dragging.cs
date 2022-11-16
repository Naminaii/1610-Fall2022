using UnityEngine;

public class dragging : MonoBehaviour
{
    private Camera cameraObj;
    public bool Draggable;
    
    private void Start()
    {
        cameraObj = Camera.main;
    }
    
    public IEnumerator OnMouseDown()
    {
        Draggable == true;
        while(Draggable == true)
        {
          yield return new WaitForFixedUpdate();
        }
    }
    
    private OnMouseUp()
    {
        Draggable == false;
    }
}
