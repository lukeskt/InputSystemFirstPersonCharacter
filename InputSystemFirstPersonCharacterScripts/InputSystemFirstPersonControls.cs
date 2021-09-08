// GENERATED AUTOMATICALLY FROM 'Assets/_InputSystemFirstPersonCharacter/FirstPersonCharacter/InputSystemFirstPersonControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputSystemFirstPersonControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputSystemFirstPersonControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputSystemFirstPersonControls"",
    ""maps"": [
        {
            ""name"": ""FPSController"",
            ""id"": ""2a8b124d-b40d-4089-9bb1-3e7687c3c29f"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6e44727f-40d2-41de-9df8-ef9c859bb7f5"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""5199bef6-c81b-4c89-a767-9d8947696c32"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Zoom"",
                    ""type"": ""Button"",
                    ""id"": ""0998abb7-9fab-4ed8-840b-668f6a9d41f7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""c863efc0-5558-4bfd-9e1f-2f090a5f5683"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""PauseMenu"",
                    ""type"": ""Button"",
                    ""id"": ""a5ad4849-694e-45e5-818f-a2eb7914c14d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""e1c66f5d-86f8-4819-9ffb-46c51392ba9b"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b2b620ce-fd94-4aa9-9452-511a00d48e5e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0a533e67-c661-464c-8486-a99fdbe48997"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""864a6caa-192d-4320-9e3e-06dc3d60bead"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""259e7673-3108-4433-8958-246644928eea"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f5a0feef-fa07-4fda-8e57-98862b13abfa"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7ca7ef42-34ce-439e-ba30-93fd2fcc6708"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b894679b-485b-41e1-ab9e-7f1d5e02c2a8"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""bea5abaf-7361-4a3b-8ea0-96e1afaf7c92"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1c67ce8f-8e4b-47fc-bee9-35bf8a7fe760"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a4145e3e-192b-4cc8-82eb-ebae065cddae"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=20,y=20)"",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de7cdca1-c0b2-4408-83fe-c06771dd6234"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=2,y=2)"",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af2e03ea-44d0-47e1-af62-ae554b91a1d9"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86ffbc8f-e77d-421f-aba6-4660814d34b1"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50e54fa5-3989-4d41-8bca-89dbd9160957"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1fa13f20-80a4-4416-9374-e7b6f4381d11"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e0d6395-4dc0-46bc-8d08-393f5dc28b31"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6776399b-937f-4092-83f0-07621e416be8"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""FPSControllerInputs"",
                    ""action"": ""PauseMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""FPSControllerInputs"",
            ""bindingGroup"": ""FPSControllerInputs"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // FPSController
        m_FPSController = asset.FindActionMap("FPSController", throwIfNotFound: true);
        m_FPSController_Move = m_FPSController.FindAction("Move", throwIfNotFound: true);
        m_FPSController_Look = m_FPSController.FindAction("Look", throwIfNotFound: true);
        m_FPSController_Zoom = m_FPSController.FindAction("Zoom", throwIfNotFound: true);
        m_FPSController_Crouch = m_FPSController.FindAction("Crouch", throwIfNotFound: true);
        m_FPSController_PauseMenu = m_FPSController.FindAction("PauseMenu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // FPSController
    private readonly InputActionMap m_FPSController;
    private IFPSControllerActions m_FPSControllerActionsCallbackInterface;
    private readonly InputAction m_FPSController_Move;
    private readonly InputAction m_FPSController_Look;
    private readonly InputAction m_FPSController_Zoom;
    private readonly InputAction m_FPSController_Crouch;
    private readonly InputAction m_FPSController_PauseMenu;
    public struct FPSControllerActions
    {
        private @InputSystemFirstPersonControls m_Wrapper;
        public FPSControllerActions(@InputSystemFirstPersonControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_FPSController_Move;
        public InputAction @Look => m_Wrapper.m_FPSController_Look;
        public InputAction @Zoom => m_Wrapper.m_FPSController_Zoom;
        public InputAction @Crouch => m_Wrapper.m_FPSController_Crouch;
        public InputAction @PauseMenu => m_Wrapper.m_FPSController_PauseMenu;
        public InputActionMap Get() { return m_Wrapper.m_FPSController; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FPSControllerActions set) { return set.Get(); }
        public void SetCallbacks(IFPSControllerActions instance)
        {
            if (m_Wrapper.m_FPSControllerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnLook;
                @Zoom.started -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnZoom;
                @Zoom.performed -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnZoom;
                @Zoom.canceled -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnZoom;
                @Crouch.started -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnCrouch;
                @PauseMenu.started -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.performed -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnPauseMenu;
                @PauseMenu.canceled -= m_Wrapper.m_FPSControllerActionsCallbackInterface.OnPauseMenu;
            }
            m_Wrapper.m_FPSControllerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Zoom.started += instance.OnZoom;
                @Zoom.performed += instance.OnZoom;
                @Zoom.canceled += instance.OnZoom;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @PauseMenu.started += instance.OnPauseMenu;
                @PauseMenu.performed += instance.OnPauseMenu;
                @PauseMenu.canceled += instance.OnPauseMenu;
            }
        }
    }
    public FPSControllerActions @FPSController => new FPSControllerActions(this);
    private int m_FPSControllerInputsSchemeIndex = -1;
    public InputControlScheme FPSControllerInputsScheme
    {
        get
        {
            if (m_FPSControllerInputsSchemeIndex == -1) m_FPSControllerInputsSchemeIndex = asset.FindControlSchemeIndex("FPSControllerInputs");
            return asset.controlSchemes[m_FPSControllerInputsSchemeIndex];
        }
    }
    public interface IFPSControllerActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnPauseMenu(InputAction.CallbackContext context);
    }
}
