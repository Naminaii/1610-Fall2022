using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
