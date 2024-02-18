using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Joystick moveJoystick;
    [SerializeField] float moveSpeed = 5.0f;

    Vector2 moveInput;

    private void Start()
    {

        moveJoystick.onStickValueUpdated += MoveInputUpdated;
    }

    private void Update()
    {
        transform.Translate(moveInput * moveSpeed * Time.deltaTime);
    }

    private void MoveInputUpdated(Vector2 inputValue)
    {
        moveInput = inputValue;
    }
}
