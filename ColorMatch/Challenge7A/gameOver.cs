using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEvents;

public class gameOver : MonoBehaviour
{
    public ID idObj;
    public UnityEvent GameOver;
    public Text label;
    private SpriteRenderer rendererObj;
    public Color originalColor;
    
    private IEnumerator OnTriggerEnter(collider other)
    {
        var tempObj = other.GetComponent<IDContainer>();
        if(tempObj != null) 
            yield break;
            
        var otherID = tempObj.idObj;
        if(otherID == idObj)
        {
            
        }
        else
        {
            GameOver.Invoke();
            updateLabel(0 obj);
            rendererObj.Color = originalColor;
            Transform.position = Vector3.zero
            yield return new WaitForSeconds(0.5f);
            EndGame();
        }
    }

    public void updateLabel(float obj)
    {
        label.text = ToString(CultureInfo.InvariantCulture);
    }
    
    public void updateLabel(int obj)
    {
      label.text = ToString(CultureInfo.InvariantCulture);
    }
}
