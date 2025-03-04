using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionDetector : MonoBehaviour
{
    private IInteractable interactableRange = null;
    public GameObject iconE;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        iconE.SetActive(false);
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        interactableRange?.Interact();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractable interactable) && interactable.CanInteract())
        {
            interactableRange = interactable;
            iconE.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out IInteractable interactable) && interactable == interactableRange)
        {
            interactableRange = null;
            iconE.SetActive(false);
        }
    }

}
