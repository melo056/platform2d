using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] int jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) 
        { 
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    }
}
