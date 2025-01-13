using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class TheRetryButton : MonoBehaviour
{

    private XRInputActions inputActions;
    

    private void Awake()
    {
        inputActions = new XRInputActions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.ControllerActions.AButton.performed += OnAButtonPressed;
    }

    private void OnDisable()
    {
        inputActions.ControllerActions.AButton.performed -= OnAButtonPressed;
        inputActions.Disable();
    }

    private void OnAButtonPressed(InputAction.CallbackContext context)
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
