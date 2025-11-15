using JetBrains.Annotations;
using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class ThirdPersonCameraController : MonoBehaviour {
    private float horizontalSpeed = 50.0f;
    private float verticalSpeed = 50.0f;
    private bool inverted;

    public float m_HorizontalSpeed { get { return horizontalSpeed; } set { } }
    public float m_VerticalSpeed { get { return verticalSpeed; } set { } }
    public bool m_Inverted { get { return inverted; } set { } }

    void LateUpdate() {
        Vector2 moveDirection = Mouse.current.delta.ReadValue(); ;
        moveDirection = Vector2.ClampMagnitude(moveDirection, 1.0f);

        StartCoroutine(RotateCamera(moveDirection));        
    }

    IEnumerator RotateCamera(Vector2 moveDirection_) {

        if (inverted == false) {
            float horizontalRotation = moveDirection_.x * horizontalSpeed * Time.deltaTime;
            float verticalRotation = -moveDirection_.y * verticalSpeed * Time.deltaTime;
            
            transform.Rotate(Vector3.up, Mathf.Clamp(horizontalRotation, -1, 1), Space.World);
            transform.Rotate(Vector3.right, Mathf.Clamp(verticalRotation, -1, 1), Space.Self);

            yield return null; 
        }
        else {
            float horizontalRotation = -moveDirection_.x * horizontalSpeed * Time.deltaTime;
            float verticalRotation = moveDirection_.y * verticalSpeed * Time.deltaTime;

            transform.Rotate(Vector3.up, Mathf.Clamp(horizontalRotation, -1, 1), Space.World);
            transform.Rotate(Vector3.right, Mathf.Clamp(verticalRotation, -1, 1), Space.Self);

            yield return null;
        }
    }

    
}
