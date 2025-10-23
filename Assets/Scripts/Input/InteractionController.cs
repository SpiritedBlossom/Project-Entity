using UnityEngine;

public class InteractionController : MonoBehaviour
{
    [SerializeField] PlayerInputController inputController;

    private Interactable target;

    private void Start()
    {
        inputController.onInteractInputReceived += Interact;
    }

    private void Interact()
    {
        target.Interact();
    }

    public void SetInteractable(Interactable interactable_)
    {
        target = interactable_;
    }
}
