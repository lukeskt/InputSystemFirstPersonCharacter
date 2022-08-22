using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class Controller : MonoBehaviour
{
    [Space]
    public float gravity = -9.81f;

    [Header("References")]
    public CharacterController controller;
    public Transform fpsCamera;
    public CinemachineVirtualCamera fpsCam;
    [Header("Movement")]
    public float walkSpeed = 5f;
    public float crouchSpeed = 2f;
    public float sprintSpeed = 10f;
    [Header("Heights")]
    public float defaultHeight = 2f;
    public float crouchHeight = 1f;
    [Space]
    [Header("Ground Checking")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask whatIsGround;

    private bool IsGrounded()
    {
        return Physics.CheckSphere(groundCheck.position, groundCheckRadius, whatIsGround);
    }

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        // DETERMINING MOVE DIRECTION
        Vector2 input = InputManager.Instance.GetMovement();
        Vector3 move = fpsCamera.right * input.x + fpsCamera.forward * input.y;
        // GRAVITY
        move.y = gravity;
        if (IsGrounded())
        {
            gravity = 0f;
        }
        else
        {
            gravity += Physics.gravity.y * Time.deltaTime;
        }
        Vector3 gravityDirection = new Vector3(0, gravity, 0);
        controller.Move(gravityDirection * Time.deltaTime);
        // CROUCH
        if (InputManager.Instance.GetCrouch())
        {
            controller.Move(move * crouchSpeed * Time.deltaTime);
            Crouch(10 * Time.deltaTime);
        }
        else
        {
            UnCrouch(10 * Time.deltaTime);
        }
        // AIM
        if (InputManager.Instance.GetAim())
        {
            Debug.Log("Aiming");
            Aim(40);
        }
        else
        {
            Aim(60);
        }
        controller.Move(move * walkSpeed * Time.deltaTime);
        // THE MAIN PART ADJUSTING THE CENTER
        controller.center = new Vector3(0, controller.height / 2, 0);
    }

    private void Crouch(float speed)
    {
        // Adjusting Height
        if (controller.height > crouchHeight)
        {
            controller.height = Mathf.Lerp(controller.height, crouchHeight, speed);
        }

    }

    private void UnCrouch(float speed)
    {
        // Adjusting Height
        if (controller.height < defaultHeight)
        {
            controller.height = Mathf.Lerp(controller.height, defaultHeight, speed);
        }
    }

    private void Aim(float fieldOfView)
    {
        float currentFOV = fpsCam.m_Lens.FieldOfView;
        float desiredFOV = Mathf.Lerp(currentFOV, fieldOfView, 10 * Time.deltaTime);
        fpsCam.m_Lens.FieldOfView = desiredFOV;
    }
}
