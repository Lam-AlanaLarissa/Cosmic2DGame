using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private LayerMask groundLayer;
    private Animator animator;
    private Rigidbody2D body;
    private BoxCollider2D boxCollider;
    private bool grounded;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y);
        //Flip
        if(horizontalInput < -0.01f)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if(horizontalInput > 0.01f)
        {
            transform.localScale = Vector3.one;
        }

        if (Input.GetKey(KeyCode.Space) && isGrounded())
        {
            Jump();
        }
            //Set animator parameters
            animator.SetBool("run", horizontalInput != 0);
            animator.SetBool("grounded", isGrounded());
            
    }
    private void Jump()
    { 
        body.velocity = new Vector2(body.velocity.x, speed);
        animator.SetTrigger("jump");
    }
    
    private bool isGrounded()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, boxCollider.bounds.size, 0, Vector2.down, 0.1f, groundLayer);
        return raycastHit.collider != null;
    }
    
}
