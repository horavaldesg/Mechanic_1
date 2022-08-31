using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    [SerializeField] float jumpForce;
    private bool grounded = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            //Change size
            rb.AddForce(new Vector2(rb.velocity.x + Input.GetAxis("Horizontal"), rb.velocity.y + jumpForce));
            grounded = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(rb.velocity.x - speed * Time.deltaTime, rb.velocity.y);

        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(rb.velocity.x + speed * Time.deltaTime, rb.velocity.y);

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            grounded = true;
        }
       
    }
}
