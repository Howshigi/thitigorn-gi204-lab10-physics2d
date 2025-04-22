using System;
using UnityEngine;

public class Camerafollow : MonoBehaviour
{
  private Vector3 offset = new Vector3(0f, 0f, -10f);
  private float smoothTime = 0.25f;
  private Vector3 velocity = Vector3.zero;

  [SerializeField] private Transform target;


  private void Update()
  {
    Vector3 targetPos = target.position + offset;
    transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
  }
}
