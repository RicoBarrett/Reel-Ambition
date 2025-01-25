// Allows the player to move

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public bool jumping;
    public bool jumpAnimation;
    public int jumpCount;
    public float dashSpeed;
    public bool running;
    public bool sprinting;
    public int dashCount;
    public float slamSpeed;
    public bool jumpEffect;
    public bool slamAnimation;
    public bool facingRight;

    private float playerInput;
    private Rigidbody2D playerBody;
    private bool isFacingRight;


    // Start is called before the first frame update
    void Start()
    {
        playerBody = GetComponent<Rigidbody2D>();

        speed = 5f;
        jumpSpeed = 8f;
        jumpCount = 1;
        dashSpeed = 10f;
        dashCount = 2;
        slamSpeed = -10f;

        InvokeRepeating("DashCount", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Jump();

        FlipPlayer();

    }

    // Change velocity of rigidbody based on user input
    void Move()
    {
        playerInput = Input.GetAxisRaw("Horizontal");


        if (!sprinting)
        {
            playerBody.velocity = new Vector2(playerInput * speed, playerBody.velocity.y);
        }
        if ((playerInput != 0) & (!jumpAnimation))
        {
            running = true;
        }
        else
        {
            running = false;
        }

        if ((Input.GetKeyDown(KeyCode.LeftShift)) & (dashCount > 0))
        {
            sprinting = true;
            StartCoroutine(Dash());

            dashCount--;
        }

    }

    void DashCount()
    {
        if (dashCount < 2)
        {
            dashCount++;
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") & !jumping)
        {

            playerBody.velocity = new Vector2(playerInput * speed, jumpSpeed);

            jumpAnimation = true;

            jumpCount--;
            
            if (jumpCount <= 0)
            {
                jumping = true;
            }
        }

        if (jumpAnimation == true)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                playerBody.velocity = new Vector2(playerInput * speed, slamSpeed);

                slamAnimation = true;
            }
        }
    }

    void FlipPlayer()
    {
        if ((isFacingRight && playerInput > 0f) || (!isFacingRight && playerInput < 0f))
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            jumping = false;
            jumpAnimation = false;
            slamAnimation = false;

            jumpCount = 1;
        }
    }

    IEnumerator Dash()
    {
        playerBody.gravityScale = 0.0f;
        playerBody.velocity = new Vector2(playerInput * dashSpeed, 0);
        yield return new WaitForSeconds(0.24f);
        sprinting = false;
        playerBody.gravityScale = 1.0f;
    }
}
