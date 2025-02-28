using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speedMax;
    private float speed;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    public GameObject rayhitObject;
    public GameObject rayhitObject2;
    public GameObject rayhitObject3;
    public GameObject rayhitObject4;


    public Transform paperCheckPos;
    public Vector2 paperCheckSize = new Vector2(1f, 1f);
    public LayerMask paperLayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D paperInfornt = Physics2D.Raycast(rayhitObject.transform.position, new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), 0.1f, paperLayer);
        RaycastHit2D paperInfornt2 = Physics2D.Raycast(rayhitObject2.transform.position, new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), 0.1f, paperLayer);
        RaycastHit2D paperInfornt3 = Physics2D.Raycast(rayhitObject3.transform.position, new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), 0.1f, paperLayer);
        RaycastHit2D paperInfornt4 = Physics2D.Raycast(rayhitObject4.transform.position, new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")), 0.1f, paperLayer);

        //Debug.Log(paperInfornt.collider != null);
        //Debug.Log(paperInfornt2.collider != null);


        if (paperInfornt.collider != null && paperInfornt2.collider != null && paperInfornt3.collider != null && paperInfornt4.collider != null)
        {
            speed = speedMax;
        }
        else
        {
            speed = 0;
        }
        rb.linearVelocity = moveInput * speed;
    }

    public void Move(InputAction.CallbackContext context)
    {

        moveInput = context.ReadValue<Vector2>();
    }

    //private void OnDrawGizmosSelected()
    //{
    //    Gizmos.color = Color.white;
    //    Gizmos.DrawCube(paperCheckPos.position, paperCheckSize);
    //}
}
