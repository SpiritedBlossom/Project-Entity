using System.Collections;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Vector2 moveVector;
    private Coroutine movementCoroutine;
    private Rigidbody rb;
    [SerializeField] private float moveSpeed;
    [SerializeField] private PlayerInputController controller;

    private void Start()
    {
        controller.onMoveInputReceived += BeginMovement;

        rb = GetComponent<Rigidbody>();
    }
    public void BeginMovement(Vector2 moveVector_)
    {
        moveVector = moveVector_;
     
    }

    private void FixedUpdate()
    {
        Vector3 input = new Vector3(moveVector.x, 0f, moveVector.y);

        Vector3 moveDirection = transform.TransformDirection(input).normalized;

        Vector3 targetVelocity = moveDirection * moveSpeed;
        targetVelocity.y = rb.linearVelocity.y;

        rb.linearVelocity = targetVelocity;
    }

}
