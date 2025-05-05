using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{
    Rigidbody2D playerRigidBody;

    float playerSpeed = 5f;
    float playerJumpForce = 5f;

    private void Awake()
    {
        playerRigidBody = GetComponentInParent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump();
    }

    private void FixedUpdate()
    {
        PlayerMovement();
    }

    void PlayerMovement()
    {
        float horizontalDirection = Input.GetAxis("Horizontal");
        playerRigidBody.velocity = new Vector2(horizontalDirection * playerSpeed, playerRigidBody.velocity.y);

        Debug.Log(horizontalDirection);
    }

    void PlayerJump()
    {
        bool jump = Input.GetKeyDown(KeyCode.Space);
        if (jump)
        {
            playerRigidBody.AddForce(Vector2.up * playerJumpForce, ForceMode2D.Impulse);
        }
    }
}
