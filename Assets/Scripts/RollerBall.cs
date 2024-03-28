using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RollerBall : MonoBehaviour
{

    public float jumpForce;
    bool isGrounded = false;

    public float ballSpeed;
    private Rigidbody ballRb;
    private float xInput, zInput; 


    // Start is called before the first frame update
    void Start()
    {
        ballSpeed = 10.0f;
        ballRb = GetComponent<Rigidbody>();
        xInput = 0.0f;
        zInput = 0.0f; 
    } 
  
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        xInput = movementVector.x;
        zInput = movementVector.y;
    }

    void OnJump(InputValue jumpValue)
    {
        if (isGrounded) {
        Vector3 ballJump = new Vector3(0, jumpForce, 0);
        ballRb.AddForce(ballJump);
            isGrounded = false;
        }
    } 

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3 (xInput,0, zInput);
        ballRb.AddForce (movement * ballSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Has hit the ground.");
            isGrounded = true;
        }
    }

}
