Using System.Collections.Genric;
Using UnityEngine;
Using UnityEngine.Events;

[CreateAssetMenu]

public class GameAction : Monobehaviour
{
    public UnityAction raise;
    
    public void RaiseAction()
    {
        raise?.Invoke();
    }
}
