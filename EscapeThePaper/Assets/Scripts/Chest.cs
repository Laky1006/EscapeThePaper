using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpen;
    public Sprite openedCorner;

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenCorner();
    }

    public bool CanInteract()
    {
        return !IsOpen;
    }

    private void OpenCorner()
    {
        if (IsOpen = true)
        {
            GetComponent<SpriteRenderer>().sprite = openedCorner;
        }
    }
}
