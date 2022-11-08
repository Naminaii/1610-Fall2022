using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehavior
{
  void Update()
  {
      transform.Translate(Vector3.forward*Time.deltaTime*speed);
      
  }
}
