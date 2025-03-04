using UnityEngine;

public class PageCorner : MonoBehaviour, IInteractable
{
    public bool IsOpen;
    public Sprite openedCorner;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        if (!CanInteract()) return;
        
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
