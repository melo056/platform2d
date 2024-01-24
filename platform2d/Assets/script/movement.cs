using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform GroundCheck;

    public float speed;
    public float jumpspeed = 4f;
    private float Move;
    public float groundcheckradius;
    public LayerMask groundLayer;
    public bool isTouchingGround;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
       
    }
    void Movement()
    {
        Move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Move * speed, rb.velocity.y);
    }

    void Jump()
    {
        isTouchingGround = Physics2D.OverlapCircle(GroundCheck.position, groundcheckradius, groundLayer);
        if (Input.GetButtonDown("Jump") && isTouchingGround == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpspeed);
            
        }
    } 
    
}
