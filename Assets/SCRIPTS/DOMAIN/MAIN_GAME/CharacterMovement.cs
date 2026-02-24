using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

   public float movementSpeed = 10f;
   public float runSpeed = 15f;
   public float jumpForce = 10f;


    private Vector3 movementVector;


    private Rigidbody rb;


    public bool canMove = true;
    public bool canJump = true;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }




    void Update()
    {
        movementVector = transform.right * Input.GetAxis("Horizontal") + Input.GetAxis("Vertical") * transform.forward;

        if (canJump)
        {
            Jump();
        }
        if (canMove)
        {
            Canmove();
        }
    }
    


    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space)&& IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }



    private void Canmove()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            rb.MovePosition(transform.position + movementVector * runSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rb.MovePosition(transform.position + movementVector * movementSpeed * Time.fixedDeltaTime);
        }
    }



    private bool IsGrounded()
    {
        Vector3 rayorig = new Vector3(transform.position.x, transform.position.y +1f, transform.position.z);

        return Physics.Raycast(rayorig,Vector3.down,1.5f, LayerMask.GetMask("Ground"));
    }
}
