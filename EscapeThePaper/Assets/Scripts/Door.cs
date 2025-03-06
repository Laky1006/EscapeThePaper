using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public bool IsOpen;
    public Sprite openedDoor;
    public GameObject numberLock;
    public PlayerController playerMove;

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenNumberLock();
    }

    public bool CanInteract()
    {
        return !IsOpen;
    }

    private void OpenNumberLock()
    {
        numberLock.SetActive(true);
        playerMove.enabled = false;
    }

    public void CloseNumberLock()
    {
        numberLock.SetActive(false);
        playerMove.enabled = true;
    }

    public void OpenChest()
    {

        if (IsOpen) return; // Prevent reopening

        IsOpen = true; // Mark chest as opened
        GetComponent<SpriteRenderer>().sprite = openedDoor;
        CloseNumberLock();

    }
}
