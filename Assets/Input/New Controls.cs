// GENERATED AUTOMATICALLY FROM 'Assets/Input/New Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""New Controls"",
    ""maps"": [
        {
            ""name"": ""Touch"",
            ""id"": ""4d3d4fc7-2d44-446b-a744-aa337445d588"",
            ""actions"": [
                {
                    ""name"": ""getPositon"",
                    ""type"": ""Value"",
                    ""id"": ""d70504c1-3720-4c90-8f20-7e9891949ddc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""87fa8d3b-af12-4df9-8093-cd37da741166"",
                    ""path"": ""<Touchscreen>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""getPositon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Touch
        m_Touch = asset.FindActionMap("Touch", throwIfNotFound: true);
        m_Touch_getPositon = m_Touch.FindAction("getPositon", throwIfNotFound: true);
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

    // Touch
    private readonly InputActionMap m_Touch;
    private ITouchActions m_TouchActionsCallbackInterface;
    private readonly InputAction m_Touch_getPositon;
    public struct TouchActions
    {
        private @NewControls m_Wrapper;
        public TouchActions(@NewControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @getPositon => m_Wrapper.m_Touch_getPositon;
        public InputActionMap Get() { return m_Wrapper.m_Touch; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(TouchActions set) { return set.Get(); }
        public void SetCallbacks(ITouchActions instance)
        {
            if (m_Wrapper.m_TouchActionsCallbackInterface != null)
            {
                @getPositon.started -= m_Wrapper.m_TouchActionsCallbackInterface.OnGetPositon;
                @getPositon.performed -= m_Wrapper.m_TouchActionsCallbackInterface.OnGetPositon;
                @getPositon.canceled -= m_Wrapper.m_TouchActionsCallbackInterface.OnGetPositon;
            }
            m_Wrapper.m_TouchActionsCallbackInterface = instance;
            if (instance != null)
            {
                @getPositon.started += instance.OnGetPositon;
                @getPositon.performed += instance.OnGetPositon;
                @getPositon.canceled += instance.OnGetPositon;
            }
        }
    }
    public TouchActions @Touch => new TouchActions(this);
    public interface ITouchActions
    {
        void OnGetPositon(InputAction.CallbackContext context);
    }
}
