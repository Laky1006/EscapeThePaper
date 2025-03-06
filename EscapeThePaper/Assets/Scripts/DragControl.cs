using UnityEngine;

public class DragControl : MonoBehaviour
{
    private bool dragging = false;
    private bool playerOn = false;
    private Vector3 offset;
    public Collider2D StickyNoteCollider;
    public Collider2D PlayerCollider;

    // Update is called once per frame
    void Update()
    {
        PlayerOn();
        if (dragging && !playerOn)
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + offset;
        }
    }

    private void OnMouseDown()
    {
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        dragging = true;
    }

    private void OnMouseUp()
    {

        dragging= false;
    }

    private void PlayerOn()
    {
        if (!dragging)
        {
            if (StickyNoteCollider.IsTouching(PlayerCollider))
            {
                playerOn = true;                
            } 
            else
            {
                playerOn = false;                
            }
        }
    }


}
