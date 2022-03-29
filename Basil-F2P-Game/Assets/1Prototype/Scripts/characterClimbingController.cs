using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class characterClimbingController : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;
    public float Speed = 5f;
    public float SpeedIncrease = 5f;
    public float SpeedLimit = 28f;
    private float moveSpeed;
    public InputAction playerControls;
   

    Vector2 moveDirection = Vector2.zero;
    int isClimbingHash;
    bool movementPressed;

    void Start()
    {
        animator = this.gameObject.GetComponent<Animator>();
        
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void OnDisable()
    {
        playerControls.Disable();
    }

    
    void Update()
    {
        moveDirection = playerControls.ReadValue<Vector2>();
        isClimbingHash = Animator.StringToHash("isClimbing");
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(moveDirection.x * Speed , moveDirection.y * Speed  );
    }

    public void _speedIncrease()
    {
        if(Speed <= SpeedLimit)
        {
            Speed += SpeedIncrease;
        }
        
    }


    void handleMovement()
    {
        bool isClimbing = animator.GetBool(isClimbingHash);

       
        if (movementPressed)
        {
            animator.SetBool(isClimbingHash, true);
        } 
        else 
        {
            animator.SetBool(isClimbingHash, false);
        }
        
    }
}
