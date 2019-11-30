using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour {   
    private CharacterController characterController;

    [Header("Button Settings")]
    public string verticalAxis;
    public string horizontalAxis;
    public string jumpButton;
    public float deadZone = 0.2f;

    // public KeyCode jumpKey;
    // public KeyCode forwardKey;
    // public KeyCode brakeKey;
    // public KeyCode rightKey;
    // public KeyCode leftKey;

    [Header("Movement Curves")]
    public AnimationCurve forwardVelocity;
    public AnimationCurve angularVelocity;
    private float forwardT;
    public float forwardTimePeriod;
    private float angularT = 0.5f;
    public float angularTimePeriod;
    public Vector2 inputAxis;
    private Vector3 rotation = Vector3.zero;



    private Vector3 moveDirection;
    public float jumpHeight;
    public float gravity;
    public float maxSpeed;
    public float turnSpeed;
    public float turnSmooth;

    private int jumpsLeft = 2;
    

    void Start() {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    void Update() {
        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        GroundedMovement();
        inputAxis = new Vector2(Input.GetAxis(horizontalAxis), Input.GetAxis(verticalAxis));
    }

    /// <summary>
    /// Allows the Player to Move
    /// </summary>
    private void GroundedMovement() {
        if (this.characterController.isGrounded) { // What player can do when grounded
            // jumpsLeft = 2; // Resets Double Jump (WONT WORK WITH MOUNTAIN)
            Movement(); // Allows for movement while grounded
            gravity = 9.81f;


            if (Input.GetButton(jumpButton)) {
                moveDirection.y = jumpHeight;
            }
            
        } else { // What player can do in the air
            // gravity += gravity * Time.deltaTime;
        }

        rotation = new Vector3(0f, Input.GetAxis(horizontalAxis), 0f);
        rotation *= turnSpeed;
        Debug.Log("Horizontal:" + rotation);

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        moveDirection = gameObject.transform.forward * forwardVelocity.Evaluate(forwardT) * maxSpeed;

        moveDirection.y -= gravity;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        characterController.transform.Rotate(rotation);

        

        // gameObject.transform.Rotate(new Vector3(0f, angularVelocity.Evaluate(angularT) * turnSpeed, 0f));

        
         // Adds effect of gravity to the player

        // Debug.Log("MOVE DIRECTION: " + moveDirection);
        
        // Turn();
        
        // characterController.Move(moveDirection * Time.deltaTime);
        // Debug.Log(moveDirection);
    }


    private void Movement() {
        if (inputAxis.y > deadZone && forwardT < 1f) {
                forwardT += (Time.deltaTime / forwardTimePeriod);
            } else if (inputAxis.y > deadZone && forwardT > 1f) {
                forwardT = 1f;
            } else if (inputAxis.y < -deadZone && forwardT > 0) {
                forwardT -= (Time.deltaTime * 5 / forwardTimePeriod);
            } else if (inputAxis.y < -deadZone && forwardT < 0) {
                forwardT = 0;
            } else if (forwardT > 0) {
                forwardT -= (Time.deltaTime * 2 / forwardTimePeriod);
            } else {
                forwardT = 0;
            }
    }
}
