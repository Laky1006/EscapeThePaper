

public interface IInteractable {
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Interact();

    // Update is called once per frame
    bool CanInteract();
}
