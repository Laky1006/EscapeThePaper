using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speedMax = 5f;
    public Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 rawInput;

    public float rayLength = 0.2f; // Adjust for precision
    public LayerMask paperLayer;

    void FixedUpdate()
    {
        if (moveInput != Vector2.zero)
        {
            Vector2 nextPosition = (Vector2)rb.position + moveInput * speedMax * Time.fixedDeltaTime;
            Vector2 rayEndPoint = rb.position + rawInput * rayLength;

            // Check if the end of the ray is still on the paper
            if (Physics2D.OverlapPoint(rayEndPoint, paperLayer))
            {
                rb.MovePosition(nextPosition);
            }
        }
    }

    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>().normalized;
        rawInput = context.ReadValue<Vector2>();
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(rb.position, moveInput * rayLength);
    }
}
