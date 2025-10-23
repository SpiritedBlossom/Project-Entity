using System.Collections;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    private Vector2 moveVector;
    private Coroutine movementCoroutine;
    [SerializeField] private float moveSpeed;
    [SerializeField] private PlayerInputController controller;

    private void Start()
    {
        controller.onMoveInputReceived += BeginMovement;
    }
    public void BeginMovement(Vector2 moveVector_)
    {
        moveVector = moveVector_;
        StartCoroutine(MovementCoroutine());
     
    }

    private IEnumerator MovementCoroutine()
    {
        while (true)
        {
            transform.position += new Vector3(moveVector.x, 0, moveVector.y) * Time.deltaTime * moveSpeed;
            yield return new WaitForEndOfFrame();
        }
    }
}
