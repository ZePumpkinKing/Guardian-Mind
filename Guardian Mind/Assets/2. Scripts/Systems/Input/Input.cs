//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/2. Scripts/Systems/Input/Input.inputactions
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

public partial class @Input: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Input()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Input"",
    ""maps"": [
        {
            ""name"": ""tactical"",
            ""id"": ""cbab3ad0-49ac-4230-a7a2-ff0f6734f5f6"",
            ""actions"": [
                {
                    ""name"": ""cursor"",
                    ""type"": ""Value"",
                    ""id"": ""46ddb4d3-0350-4741-bec4-be67e82d9c15"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""1bfff7a1-442a-40b4-883a-1096dbb72078"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""zoom"",
                    ""type"": ""Value"",
                    ""id"": ""49e473b7-c153-4691-8a2d-6c419fce7879"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""rotate"",
                    ""type"": ""Value"",
                    ""id"": ""762053f1-024e-48c2-b6e8-50660c7cc6f6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""turn"",
                    ""type"": ""Button"",
                    ""id"": ""3dc46ff2-4e66-42b9-aaab-001f939397e9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""select"",
                    ""type"": ""Button"",
                    ""id"": ""ecf090ea-d1a2-475d-86ac-b292a2795f2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""interact"",
                    ""type"": ""Button"",
                    ""id"": ""234c8e7e-27de-4ecf-9c3a-3cc2c52030da"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c720ba32-38a3-48f5-a4c4-dd81444c163e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""cursor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""57832cc9-47e9-4ff8-9c32-88bcccb98d50"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""09cfed4c-a574-449c-b529-2fd0c9ba134a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0f1a2470-2a5a-4b89-a0d8-da36578d9eac"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b8405446-b977-402c-8875-086351c6fddc"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""21284b3f-e4b5-4aed-894d-f493a8a48134"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""a8368082-305b-4087-9ae7-e9bd01713440"",
                    ""path"": ""<Mouse>/scroll"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""zoom"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""d7aff98b-38c8-403f-9d4a-fcbdceb4ea21"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""43c40d1c-859c-4361-bbab-b18d26fa62ae"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""80e7f782-8896-4b84-9ff5-e4228a9de82d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""effe5b96-cfbc-431c-a611-af49dfbdd2a5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""turn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e964281-e578-4d87-bfb7-2eada1efceea"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""select"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bf1e141b-de88-4420-a4aa-b66df7ec91a8"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // tactical
        m_tactical = asset.FindActionMap("tactical", throwIfNotFound: true);
        m_tactical_cursor = m_tactical.FindAction("cursor", throwIfNotFound: true);
        m_tactical_move = m_tactical.FindAction("move", throwIfNotFound: true);
        m_tactical_zoom = m_tactical.FindAction("zoom", throwIfNotFound: true);
        m_tactical_rotate = m_tactical.FindAction("rotate", throwIfNotFound: true);
        m_tactical_turn = m_tactical.FindAction("turn", throwIfNotFound: true);
        m_tactical_select = m_tactical.FindAction("select", throwIfNotFound: true);
        m_tactical_interact = m_tactical.FindAction("interact", throwIfNotFound: true);
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

    // tactical
    private readonly InputActionMap m_tactical;
    private List<ITacticalActions> m_TacticalActionsCallbackInterfaces = new List<ITacticalActions>();
    private readonly InputAction m_tactical_cursor;
    private readonly InputAction m_tactical_move;
    private readonly InputAction m_tactical_zoom;
    private readonly InputAction m_tactical_rotate;
    private readonly InputAction m_tactical_turn;
    private readonly InputAction m_tactical_select;
    private readonly InputAction m_tactical_interact;
    public struct TacticalActions
    {
        private @Input m_Wrapper;
        public TacticalActions(@Input wrapper) { m_Wrapper = wrapper; }
        public InputAction @cursor => m_Wrapper.m_tactical_cursor;
        public InputAction @move => m_Wrapper.m_tactical_move;
        public InputAction @zoom => m_Wrapper.m_tactical_zoom;
        public InputAction @rotate => m_Wrapper.m_tactical_rotate;
        public InputAction @turn => m_Wrapper.m_tactical_turn;
        public InputAction @select => m_Wrapper.m_tactical_select;
        public InputAction @interact => m_Wrapper.m_tactical_interact;
        public InputActionMap Get() { return m_Wrapper.m_tactical; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TacticalActions set) { return set.Get(); }
        public void AddCallbacks(ITacticalActions instance)
        {
            if (instance == null || m_Wrapper.m_TacticalActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_TacticalActionsCallbackInterfaces.Add(instance);
            @cursor.started += instance.OnCursor;
            @cursor.performed += instance.OnCursor;
            @cursor.canceled += instance.OnCursor;
            @move.started += instance.OnMove;
            @move.performed += instance.OnMove;
            @move.canceled += instance.OnMove;
            @zoom.started += instance.OnZoom;
            @zoom.performed += instance.OnZoom;
            @zoom.canceled += instance.OnZoom;
            @rotate.started += instance.OnRotate;
            @rotate.performed += instance.OnRotate;
            @rotate.canceled += instance.OnRotate;
            @turn.started += instance.OnTurn;
            @turn.performed += instance.OnTurn;
            @turn.canceled += instance.OnTurn;
            @select.started += instance.OnSelect;
            @select.performed += instance.OnSelect;
            @select.canceled += instance.OnSelect;
            @interact.started += instance.OnInteract;
            @interact.performed += instance.OnInteract;
            @interact.canceled += instance.OnInteract;
        }

        private void UnregisterCallbacks(ITacticalActions instance)
        {
            @cursor.started -= instance.OnCursor;
            @cursor.performed -= instance.OnCursor;
            @cursor.canceled -= instance.OnCursor;
            @move.started -= instance.OnMove;
            @move.performed -= instance.OnMove;
            @move.canceled -= instance.OnMove;
            @zoom.started -= instance.OnZoom;
            @zoom.performed -= instance.OnZoom;
            @zoom.canceled -= instance.OnZoom;
            @rotate.started -= instance.OnRotate;
            @rotate.performed -= instance.OnRotate;
            @rotate.canceled -= instance.OnRotate;
            @turn.started -= instance.OnTurn;
            @turn.performed -= instance.OnTurn;
            @turn.canceled -= instance.OnTurn;
            @select.started -= instance.OnSelect;
            @select.performed -= instance.OnSelect;
            @select.canceled -= instance.OnSelect;
            @interact.started -= instance.OnInteract;
            @interact.performed -= instance.OnInteract;
            @interact.canceled -= instance.OnInteract;
        }

        public void RemoveCallbacks(ITacticalActions instance)
        {
            if (m_Wrapper.m_TacticalActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ITacticalActions instance)
        {
            foreach (var item in m_Wrapper.m_TacticalActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_TacticalActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public TacticalActions @tactical => new TacticalActions(this);
    public interface ITacticalActions
    {
        void OnCursor(InputAction.CallbackContext context);
        void OnMove(InputAction.CallbackContext context);
        void OnZoom(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnTurn(InputAction.CallbackContext context);
        void OnSelect(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
