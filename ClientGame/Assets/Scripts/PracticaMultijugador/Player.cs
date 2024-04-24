using System;
using System.Collections;
using System.Collections.Generic;
using Mirror;
using UnityEngine;

public class Player : NetworkBehaviour
{
  public float speed = 0.1f;
  void HandleMovement()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    Vector3 movement = new Vector3(moveHorizontal* speed , moveVertical* speed, 0);

    transform.position = transform.position + movement;
  }

  private void Update()
  {
    HandleMovement();
  }
}
