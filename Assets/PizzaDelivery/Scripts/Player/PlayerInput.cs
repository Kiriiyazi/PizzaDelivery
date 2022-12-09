using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private DynamicJoystick _joystick;
    private PlayerMover _mover;

    private void Start()
    {
        _mover = GetComponent<PlayerMover>();
    }

    private void FixedUpdate()
    {
        float xMovement = _joystick.Horizontal;

        if (xMovement > 0)
            _mover.UpSpeed();
        else if (xMovement < 0)
            _mover.SlowSpeed();
         

    }
}
