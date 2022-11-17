using.Systems;
using.Systems.Collections;
using.UnityEngine;
using.UnityEvents;

[RequireComponent(typeof(Text))]

public class TextLabelBehavior : MonoBehaviour
{
    public UnityEvent startEvent;
    public Text label;
    
    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
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
