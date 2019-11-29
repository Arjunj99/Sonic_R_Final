using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMove : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 6.0f;
    public float turnSpeed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

    public KeyCode forward;
    public KeyCode brake;
    public KeyCode right;
    public KeyCode left;

    public string horizontal;
    public string vetical;
    // private float verticalAxis;
    // private float horizontalAxis;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {




        if (characterController.isGrounded) {
        //     if (Input.GetKey(forward) && verticalAxis < 1f) {
        //         verticalAxis += 0.1f;
        //     } else if (Input.GetKey(forward) && verticalAxis > 1f) {
        //         verticalAxis = 1f;
        //     }

        //     if (Input.GetKey(brake) && verticalAxis > 0f) {
        //         verticalAxis -= 0.1f;
        //     } else if (Input.GetKey(forward) verticalAxis)


            moveDirection = Input.GetAxis(vetical) * gameObject.transform.forward;
            moveDirection *= speed;





            if (Input.GetButton("Jump")) {
                moveDirection.y = jumpSpeed;
            }
        }

        rotation = new Vector3(0f, Input.GetAxis(horizontal), 0f);
        rotation *= turnSpeed;
        Debug.Log("Horizontal:" + rotation);

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        characterController.transform.Rotate(rotation);
    }
}
