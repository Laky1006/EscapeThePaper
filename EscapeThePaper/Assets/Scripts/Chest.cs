using UnityEngine;

public class Chest : MonoBehaviour, IInteractable
{
    public bool IsOpen;
    public Sprite openedChest;
    public GameObject combinationLock;

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
    }

    public void CloseCombinationLock()
    {
        combinationLock.SetActive(false);
    }

    private void OpenChest()
    {
        if (IsOpen = true)
        {
            GetComponent<SpriteRenderer>().sprite = openedChest;
        }
    }
}
