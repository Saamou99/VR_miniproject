//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/InputActions/XRInputActions.inputactions
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

public partial class @XRInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @XRInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XRInputActions"",
    ""maps"": [
        {
            ""name"": ""ControllerActions"",
            ""id"": ""0e0c55d7-f599-4d4e-994c-1b3419c9acba"",
            ""actions"": [
                {
                    ""name"": ""A Button"",
                    ""type"": ""Button"",
                    ""id"": ""ebb9adc1-0ee8-47da-9f05-131c1116e7b4"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3d91add6-bc95-4617-8753-b23ac80e60b3"",
                    ""path"": ""<XRInputV1::Oculus::OculusTouchControllerOpenXR>/primarybutton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A Button"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // ControllerActions
        m_ControllerActions = asset.FindActionMap("ControllerActions", throwIfNotFound: true);
        m_ControllerActions_AButton = m_ControllerActions.FindAction("A Button", throwIfNotFound: true);
    }

    ~@XRInputActions()
    {
        UnityEngine.Debug.Assert(!m_ControllerActions.enabled, "This will cause a leak and performance issues, XRInputActions.ControllerActions.Disable() has not been called.");
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

    // ControllerActions
    private readonly InputActionMap m_ControllerActions;
    private List<IControllerActionsActions> m_ControllerActionsActionsCallbackInterfaces = new List<IControllerActionsActions>();
    private readonly InputAction m_ControllerActions_AButton;
    public struct ControllerActionsActions
    {
        private @XRInputActions m_Wrapper;
        public ControllerActionsActions(@XRInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @AButton => m_Wrapper.m_ControllerActions_AButton;
        public InputActionMap Get() { return m_Wrapper.m_ControllerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ControllerActionsActions set) { return set.Get(); }
        public void AddCallbacks(IControllerActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_ControllerActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ControllerActionsActionsCallbackInterfaces.Add(instance);
            @AButton.started += instance.OnAButton;
            @AButton.performed += instance.OnAButton;
            @AButton.canceled += instance.OnAButton;
        }

        private void UnregisterCallbacks(IControllerActionsActions instance)
        {
            @AButton.started -= instance.OnAButton;
            @AButton.performed -= instance.OnAButton;
            @AButton.canceled -= instance.OnAButton;
        }

        public void RemoveCallbacks(IControllerActionsActions instance)
        {
            if (m_Wrapper.m_ControllerActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IControllerActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_ControllerActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ControllerActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ControllerActionsActions @ControllerActions => new ControllerActionsActions(this);
    public interface IControllerActionsActions
    {
        void OnAButton(InputAction.CallbackContext context);
    }
}
