using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    [SerializeField] private Transform _targetTransform;
    [SerializeField] private Vector3 _offset;
    [SerializeField] private float _smoothing;

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 nextPosition = Vector3.Lerp(transform.position, _targetTransform.position + _offset, _smoothing * Time.fixedDeltaTime);
        transform.position = nextPosition;
    }
}
