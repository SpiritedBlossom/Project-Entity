using Sirenix.Serialization;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInputController : MonoBehaviour
{
    [Sirenix.OdinInspector.BoxGroup("Input Actions")]
    public InputAction move;
    public InputAction interact;
    public InputAction run;
    public InputAction crouch;
    public InputAction shoot;

    public event Action<Vector2> onMoveInputReceived;
    public event Action onInteractInputReceived;
    public event Action onRunInputReceived;
    public event Action onCrouchInputReceived;
    public event Action onShootInputReceived;



    private void Awake()
    {
        // enable inputs
        move.Enable();
        interact.Enable();
        run.Enable();
        crouch.Enable();
        shoot.Enable();
        InitializeInputHooks();
        
    }
    
    void InitializeInputHooks()
    {
        move.performed += OnMoveInput;
        move.canceled += OnMoveInput;
        shoot.performed += OnShootInput;
        crouch.performed += OnCrouchInput;
        run.performed += OnRunInput;
        interact.performed += OnInteractInput;
    }

    void OnMoveInput(InputAction.CallbackContext c)
    {
        
        onMoveInputReceived?.Invoke(c.ReadValue<Vector2>());
    }
    void OnShootInput(InputAction.CallbackContext c)
    {
        onShootInputReceived?.Invoke();
    }

    void OnCrouchInput(InputAction.CallbackContext c)
    {
        onCrouchInputReceived?.Invoke();
    }

    void OnRunInput(InputAction.CallbackContext c)
    {
        onRunInputReceived?.Invoke();
    }

    void OnInteractInput(InputAction.CallbackContext c)
    {
        onInteractInputReceived?.Invoke(); 
    }
}
