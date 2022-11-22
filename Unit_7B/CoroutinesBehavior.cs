using UnityEngine.Events;
using System.Collections.Generic;
using UnityEngine;

public class CoroutinesBehavior : MonoBehaviour
{
    public bool canRun = false;
    public int counterNum = 3;
    public float seconds = 3.0f;
    private WaitForSeconds wfsObj;
    private WaitForFixedUpdate wffuObj;
    public UnityEvent startCountEvent, repeatCountEvent, endCountEvent, repeatUntilFalse, startEvent;
    
    public void Start()
    {
       startEvent.Invoke();
    }
    
    public void StartCounting()
    {
        wfsObj = new WaitForSeconds(seconds);
        wffuObj = new WaitForFixedUpdate();
        startEvent.Invoke();
    }
    
    private IEnumerator Counting()
    {
        startCountEvent.Invoke();
        yield return wfsObj;
        
        while (counterNum.value > 0)
        {
            repeatCountEvent.Invoke();
            counterNum.value--;
            yield return wfsObj;
        }
        
        endCountEvent.Invoke();
    }
    
    public void startRepeatTillFalse()
    {
        canRun = true;
        StartCouroutine(RepeatUntilFalse());
    }
    
    private IEnumerator RepeatUntilFalse()
    {
        while (canRun = true)
        {
            yield return wfsObj;
            repeatUntilFalse.Invoke();
        }
    }
}
