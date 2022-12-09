using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _maxSpead;
    [SerializeField] private float _minSpead;
    [SerializeField] private float _defaultSpeed;
    [SerializeField] private float _speedStep;

    private Transform _transform;
    private float _currenSpeed;

    private void Awake()
    {
        _currenSpeed = _defaultSpeed;
        _transform = GetComponent<Transform>();
    }


    private void FixedUpdate()
    {
        SpeedPlayer();
    }

    public void UpSpeed()
    {
        if (_currenSpeed < _maxSpead)
            _currenSpeed += _speedStep;

    }

    public void SlowSpeed()
    {
        if (_currenSpeed > _minSpead)
            _currenSpeed -= _speedStep;
    }

    private void SpeedPlayer()
    {
        _transform.position += new Vector3(_currenSpeed * Time.fixedDeltaTime, 0);
    }

    
}
