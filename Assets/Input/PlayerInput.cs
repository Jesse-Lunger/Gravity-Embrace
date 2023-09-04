//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Input/PlayerInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""OnFoot"",
            ""id"": ""0e3e69f9-2eb3-46c8-8beb-a8eb70817ccc"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""3684a7de-0200-4263-91ca-4aeffbb8256f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f9955520-62e2-428b-9855-d7ccd8af082e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""6e77e376-21c7-47e4-9ccb-1df6696ff585"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""GravityShiftUp"",
                    ""type"": ""Button"",
                    ""id"": ""fef4bccc-2e7a-4ab5-84b2-1e60018cd045"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GravityShiftDown"",
                    ""type"": ""Button"",
                    ""id"": ""37430bd7-6278-4bc9-a5d1-4a28282873c7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GravityShiftRight"",
                    ""type"": ""Button"",
                    ""id"": ""07c6766b-a767-4fa6-8764-e47296f2817d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GravityShiftLeft"",
                    ""type"": ""Button"",
                    ""id"": ""d60df79c-201f-4845-9c64-3dc45f99ceb2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GravityShiftForward"",
                    ""type"": ""Button"",
                    ""id"": ""851ec0cc-6d7c-4773-acfd-eb95a00678ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""GravityShiftBackward"",
                    ""type"": ""Button"",
                    ""id"": ""69f6350f-f24b-4009-b972-ab610fd3463e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""508f2021-3b40-402a-9a10-e97f777082a0"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7b1b9d56-b554-4144-bce9-48fbb47a6807"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9f3632e6-3df6-4885-82ce-3551d9024042"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""42a88ccf-bed0-4300-b6cf-6e80e15a96c5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""32b0c78c-be76-4077-81c0-54dc045f5f46"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""lEFTsTICK"",
                    ""id"": ""c97c5954-444b-4d41-880a-167ee5e56282"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""072976aa-dc5f-44a3-bcbc-502919675508"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc5fdeab-e339-4825-898f-12bbd7b55f4f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""9c847afd-d577-4b79-a394-1b4501c525b1"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c5c71e12-e45c-49d4-96a4-bc048daea34d"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ea921a3a-4c31-4255-8184-42c31a49779f"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3711fbc1-acdb-4640-ae6b-435124b07eb0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4afdcb6d-b4b1-4edf-9e61-f08b73e8d9d2"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99e70e62-6fc2-48fd-81e2-57673e2c3984"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""340f2392-810b-4307-be04-1a7733d2efad"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GravityShiftUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a24f46c-935c-4700-9e40-750d30ec32af"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GravityShiftDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b9be753e-52c6-47fd-aca2-45f398cebc05"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GravityShiftRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ac46ee69-25f8-4908-bc2f-eabe7cbd70b1"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GravityShiftLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e6a9643-2b65-4f30-b006-68aa7160316a"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GravityShiftForward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6bdefc2-ca08-4d73-8d05-990747a676ef"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GravityShiftBackward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // OnFoot
        m_OnFoot = asset.FindActionMap("OnFoot", throwIfNotFound: true);
        m_OnFoot_Movement = m_OnFoot.FindAction("Movement", throwIfNotFound: true);
        m_OnFoot_Jump = m_OnFoot.FindAction("Jump", throwIfNotFound: true);
        m_OnFoot_Look = m_OnFoot.FindAction("Look", throwIfNotFound: true);
        m_OnFoot_GravityShiftUp = m_OnFoot.FindAction("GravityShiftUp", throwIfNotFound: true);
        m_OnFoot_GravityShiftDown = m_OnFoot.FindAction("GravityShiftDown", throwIfNotFound: true);
        m_OnFoot_GravityShiftRight = m_OnFoot.FindAction("GravityShiftRight", throwIfNotFound: true);
        m_OnFoot_GravityShiftLeft = m_OnFoot.FindAction("GravityShiftLeft", throwIfNotFound: true);
        m_OnFoot_GravityShiftForward = m_OnFoot.FindAction("GravityShiftForward", throwIfNotFound: true);
        m_OnFoot_GravityShiftBackward = m_OnFoot.FindAction("GravityShiftBackward", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // OnFoot
    private readonly InputActionMap m_OnFoot;
    private List<IOnFootActions> m_OnFootActionsCallbackInterfaces = new List<IOnFootActions>();
    private readonly InputAction m_OnFoot_Movement;
    private readonly InputAction m_OnFoot_Jump;
    private readonly InputAction m_OnFoot_Look;
    private readonly InputAction m_OnFoot_GravityShiftUp;
    private readonly InputAction m_OnFoot_GravityShiftDown;
    private readonly InputAction m_OnFoot_GravityShiftRight;
    private readonly InputAction m_OnFoot_GravityShiftLeft;
    private readonly InputAction m_OnFoot_GravityShiftForward;
    private readonly InputAction m_OnFoot_GravityShiftBackward;
    public struct OnFootActions
    {
        private @PlayerInput m_Wrapper;
        public OnFootActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_OnFoot_Movement;
        public InputAction @Jump => m_Wrapper.m_OnFoot_Jump;
        public InputAction @Look => m_Wrapper.m_OnFoot_Look;
        public InputAction @GravityShiftUp => m_Wrapper.m_OnFoot_GravityShiftUp;
        public InputAction @GravityShiftDown => m_Wrapper.m_OnFoot_GravityShiftDown;
        public InputAction @GravityShiftRight => m_Wrapper.m_OnFoot_GravityShiftRight;
        public InputAction @GravityShiftLeft => m_Wrapper.m_OnFoot_GravityShiftLeft;
        public InputAction @GravityShiftForward => m_Wrapper.m_OnFoot_GravityShiftForward;
        public InputAction @GravityShiftBackward => m_Wrapper.m_OnFoot_GravityShiftBackward;
        public InputActionMap Get() { return m_Wrapper.m_OnFoot; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(OnFootActions set) { return set.Get(); }
        public void AddCallbacks(IOnFootActions instance)
        {
            if (instance == null || m_Wrapper.m_OnFootActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_OnFootActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @GravityShiftUp.started += instance.OnGravityShiftUp;
            @GravityShiftUp.performed += instance.OnGravityShiftUp;
            @GravityShiftUp.canceled += instance.OnGravityShiftUp;
            @GravityShiftDown.started += instance.OnGravityShiftDown;
            @GravityShiftDown.performed += instance.OnGravityShiftDown;
            @GravityShiftDown.canceled += instance.OnGravityShiftDown;
            @GravityShiftRight.started += instance.OnGravityShiftRight;
            @GravityShiftRight.performed += instance.OnGravityShiftRight;
            @GravityShiftRight.canceled += instance.OnGravityShiftRight;
            @GravityShiftLeft.started += instance.OnGravityShiftLeft;
            @GravityShiftLeft.performed += instance.OnGravityShiftLeft;
            @GravityShiftLeft.canceled += instance.OnGravityShiftLeft;
            @GravityShiftForward.started += instance.OnGravityShiftForward;
            @GravityShiftForward.performed += instance.OnGravityShiftForward;
            @GravityShiftForward.canceled += instance.OnGravityShiftForward;
            @GravityShiftBackward.started += instance.OnGravityShiftBackward;
            @GravityShiftBackward.performed += instance.OnGravityShiftBackward;
            @GravityShiftBackward.canceled += instance.OnGravityShiftBackward;
        }

        private void UnregisterCallbacks(IOnFootActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @GravityShiftUp.started -= instance.OnGravityShiftUp;
            @GravityShiftUp.performed -= instance.OnGravityShiftUp;
            @GravityShiftUp.canceled -= instance.OnGravityShiftUp;
            @GravityShiftDown.started -= instance.OnGravityShiftDown;
            @GravityShiftDown.performed -= instance.OnGravityShiftDown;
            @GravityShiftDown.canceled -= instance.OnGravityShiftDown;
            @GravityShiftRight.started -= instance.OnGravityShiftRight;
            @GravityShiftRight.performed -= instance.OnGravityShiftRight;
            @GravityShiftRight.canceled -= instance.OnGravityShiftRight;
            @GravityShiftLeft.started -= instance.OnGravityShiftLeft;
            @GravityShiftLeft.performed -= instance.OnGravityShiftLeft;
            @GravityShiftLeft.canceled -= instance.OnGravityShiftLeft;
            @GravityShiftForward.started -= instance.OnGravityShiftForward;
            @GravityShiftForward.performed -= instance.OnGravityShiftForward;
            @GravityShiftForward.canceled -= instance.OnGravityShiftForward;
            @GravityShiftBackward.started -= instance.OnGravityShiftBackward;
            @GravityShiftBackward.performed -= instance.OnGravityShiftBackward;
            @GravityShiftBackward.canceled -= instance.OnGravityShiftBackward;
        }

        public void RemoveCallbacks(IOnFootActions instance)
        {
            if (m_Wrapper.m_OnFootActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IOnFootActions instance)
        {
            foreach (var item in m_Wrapper.m_OnFootActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_OnFootActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public OnFootActions @OnFoot => new OnFootActions(this);
    public interface IOnFootActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnGravityShiftUp(InputAction.CallbackContext context);
        void OnGravityShiftDown(InputAction.CallbackContext context);
        void OnGravityShiftRight(InputAction.CallbackContext context);
        void OnGravityShiftLeft(InputAction.CallbackContext context);
        void OnGravityShiftForward(InputAction.CallbackContext context);
        void OnGravityShiftBackward(InputAction.CallbackContext context);
    }
}
