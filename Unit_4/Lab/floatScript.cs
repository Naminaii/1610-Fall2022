using UnityEngine;

[CreateAssetMenu]

public class floatscript : ScriptableObject
{
   public float Value; 
   
   public void UpdateValue(float num)
   {
      Value =+ num;
   }
}
