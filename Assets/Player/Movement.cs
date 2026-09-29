 using UnityEngine;

public class Movement : MonoBehaviour
{

    [Header("Movement")]
    public float walkSpeed = 5f;
    public float runSpeed = 8f;

    [Header("Jump")]
    public float jumpForce = 10f;

    [Header("Ground Check")]
    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;
    private Animator animator;
    private Rigidbody2D rb;

    private float horizontalInput;
    private bool isGrounded;
    private bool isRunning;
    private int doubleJumpValue = 1;
    private int doubleJump;


    void Awake()
    {
       rb = GetComponent<Rigidbody2D>();
       doubleJump = doubleJumpValue;
       animator = GetComponent<Animator>();
    }

    void Update()
    {
        //Left & Right Movement
        horizontalInput = Input.GetAxisRaw("Horizontal");
        bool isMove = horizontalInput > 0.1f || horizontalInput < -0.1;
        animator.SetBool("Run", isMove);
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(
                Mathf.Abs(transform.localScale.x),
                transform.localScale.y
            );
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(
                -Mathf.Abs(transform.localScale.x),
                transform.localScale.y
            );
        }
        //Run with Left Shift
        isRunning = Input.GetKey(KeyCode.LeftShift);

        //Check if player is touching ground
        isGrounded = Physics2D.OverlapCircle(
        groundCheck.position, groundCheckRadius, groundLayer);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(
            rb.linearVelocity.x, jumpForce);
            doubleJump = doubleJumpValue;

        }

      

    }
    void FixedUpdate()
    {
        float currentSpeed = isRunning ? runSpeed : walkSpeed;

        rb.linearVelocity = new Vector2(
        horizontalInput * currentSpeed, rb.linearVelocity.y);
    }
}


