using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeMode : Monobehavior
{
  public class ShiftingColors : Monobehavior
  {
    void update()
    {
        if (Input.GetKeyDown(KeyCode.P)
        {
          GetComponent<Renderer>().material.color = Color.purple;
        }
      
        if (Input.GetKeyDown(KeyCode.Y)
        {
          GetComponent<Renderer>().material.color = Color.yellow;
        }
      
        if (Input.GetKeyDown(KeyCode.G)
        {
          GetComponent<Renderer>().material.color = Color.green;
        }
    }
    
    public class VariablesAndFunctions : Monobehavior
    {
        int myInt = 5;
        
        void Start()
        {
            myInt = MultiplyByTwo(myInt);
            Debug.Log(myInt);
        }
        
        int MultiplyByTwo(int number)
        {
            int ret;
            
            result = number * 2;
            return ret;
        }
      }
    }
}
