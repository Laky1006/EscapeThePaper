using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpen;
    public Sprite openedChest;
    public GameObject combinationLock;
    public PlayerController playerMove;

    public GameObject puzzlePiece;

    public void Interact()
    {
        if (!CanInteract()) return;
        OpenCombinationLock();
    }

    public bool CanInteract()
    {
        return !IsOpen;
    }

    private void OpenCombinationLock()
    {
        combinationLock.SetActive(true);
        playerMove.enabled = false;
    }

    public void CloseCombinationLock()
    {
        combinationLock.SetActive(false);
        playerMove.enabled = true;
    }

    public void OpenChest()
    {
        
        if (IsOpen) return; // Prevent reopening

        IsOpen = true; // Mark chest as opened
        GetComponent<SpriteRenderer>().sprite = openedChest;
        CloseCombinationLock();
        Debug.Log("Chest is now open!");

        puzzlePiece.SetActive(true);
        
    }
}
