using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecayCubePart : MonoBehaviour
{
  public int startIndex;
  public Vector3 originpos;
  public float distance;
  public DecayCube manager;
  private void Start() {
    originpos = transform.position;
  }
  private void OnMouseDrag() {
    Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
    Vector3 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
    transform.position = objectPosition;
  }

  private void OnMouseUp() {
    manager.ExchangeChild(startIndex, transform);
  }
}
