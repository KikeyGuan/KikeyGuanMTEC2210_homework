using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//taken from unity scripting API: character controller move
public class playermove : MonoBehaviour
{
    
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 6f;
    //private float jumpHeight = 1.0f;
    private float gravityValue = -9.81f;
    Rigidbody rb;
    public Transform orientation;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        playerVelocity = new Vector3(0,2.0f,0);
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (controller.isGrounded)
        {
            Debug.Log ("grounded");
        }
        if (groundedPlayer && playerVelocity.y > 0)
        {
            Debug.Log ("that one if statement");
            //playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            Debug.Log ("jumped");
            playerVelocity.y = playerVelocity.y + 2f;
            //transform.position = transform.position + new Vector3(0,jumpHeight*playerSpeed*Time.deltaTime,0);

            //playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            //rb.AddForce(playerVelocity * jumpHeight, ForceMode.Impulse);
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
    
    //public float moveSpeed;

}


