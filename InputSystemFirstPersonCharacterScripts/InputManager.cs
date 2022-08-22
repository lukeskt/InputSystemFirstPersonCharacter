using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public InputSystemFirstPersonControls sampleInputs;

    // INITIALIZE INPUT SYSTEM

    private static InputManager _instance;

    public static InputManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        sampleInputs = new InputSystemFirstPersonControls();
    }

    private void OnEnable()
    {
        sampleInputs.Enable();
    }

    private void OnDisable()
    {
        sampleInputs.Disable();
    }

    // PUBLIC GET FUNCTIONS

    public Vector2 GetMovement()
    {
        return sampleInputs.FPSController.Move.ReadValue<Vector2>();
    }

    public bool GetAim()
    {
        return sampleInputs.FPSController.Zoom.ReadValue<float>() > 0;
    }

    public bool GetCrouch()
    {
        return sampleInputs.FPSController.Crouch.ReadValue<float>() > 0;
    }
}
