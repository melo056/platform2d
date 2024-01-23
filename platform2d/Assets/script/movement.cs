using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public float speed;
    private float Move;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
       
    }
    void Movement()
    {
        Move = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(Move * speed, rb.velocity.y);
    }
   
}
