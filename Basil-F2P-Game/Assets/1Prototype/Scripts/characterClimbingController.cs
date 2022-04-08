using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class characterClimbingController : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;
    public float Speed = 5f;
    public float SpeedIncrease = 5f;
    public float SpeedLimit = 28f;

    public float Health = 3;
    public float Damage = 1;

    public bool DeathOccured = false;
    //public bool _NoRevive = false;


    private float moveSpeed;
    public InputAction playerControls;
   

    Vector2 moveDirection = Vector2.zero;
    

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
        

    }

    private void FixedUpdate()
    {
        if(rb.position.x < -10 )
        {
            moveDirection.x = 0.1f;
        }

        if(rb.position.x > 10 )
        {
            moveDirection.x = -0.1f;
        }

        rb.velocity = new Vector2(moveDirection.x * Speed , /*moveDirection.y * */ Speed  );
    }

    public void _speedIncrease()
    {
        if(Speed <= SpeedLimit)
        {
            Speed += SpeedIncrease;
        }
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "cube" )
        {
            //transform.Translate(x, y, z, ralativeTo);
            //transform.Translate(0, -10, 0);
            transform.Translate(Vector3.down * Time.deltaTime );
            DamageHealth();
        }
    }

    private void DamageHealth()
    {
        Health -= Damage;
        //Debug.Log("Player Was Damaged");

        if (Health < 1)
        {
            //Debug.Log("Player Has Died");
            Death();
            //SceneManager.LoadScene("Prototype");
        }
    }

    public void Death()
    {
        //Destroy(gameObject);
        DeathOccured = true;
        print("Death Occured");
        
    }
    /*
    public void NoRevive()
    {
        _NoRevive = true;
    }
    */
}
