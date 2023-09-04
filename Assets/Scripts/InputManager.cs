using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;

    // PlayerInput.OnFootActions onFootActions = playerInput.onFoot;
    // PlayerInput.OnFootActions.GravityShift gravityShift = onFootActions.gravityShift;


    private PlayerMotor motor;
    private PlayerLook look;

    void Awake()
    {
        playerInput = new PlayerInput();
        onFoot = playerInput.OnFoot;
        motor = GetComponent<PlayerMotor>();
        look = GetComponent<PlayerLook>();

        //performed/started/canceled
        onFoot.Jump.performed += ctx => motor.jump();
        onFoot.GravityShiftUp.performed += ctx => motor.shiftUp();
        onFoot.GravityShiftDown.performed += ctx => motor.shiftDown();

        onFoot.GravityShiftLeft.performed += ctx => motor.shiftLeft();
        onFoot.GravityShiftRight.performed += ctx => motor.shiftRight();
        onFoot.GravityShiftForward.performed += ctx => motor.shiftForward();
        onFoot.GravityShiftBackward.performed += ctx => motor.shiftBackward();
    }   

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        // Call ProcessMove with the input value from onFoot.Movement.ReadValue<Vector2>()
        motor.ProcessMove(onFoot.Movement.ReadValue<Vector2>());


    }

    void LateUpdate()
    {
        look.ProcessLook(onFoot.Look.ReadValue<Vector2>());

    }

    private void OnEnable()
    {
        onFoot.Enable();
    }

    private void OnDisable()
    {
        onFoot.Disable();
    }
}
