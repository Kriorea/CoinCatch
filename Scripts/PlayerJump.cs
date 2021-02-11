using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerJump : MonoBehaviour
{
    private Rigidbody2D rb;
    
    public float jumpForce = 5f;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;

   
   private void Start()
   {
       rb = GetComponent<Rigidbody2D>();
   }


   private void FixedUpdate()
   {
       isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
   }
    private void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = 2;
        }
        if (Input.touchCount > 0 && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
        }

        
    
        
    }
}
