using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Allows a GameObject to move based on a Character Controller.
/// </summary>
/// <author> Arjun Jaishankar </author>
/// <version> 12/02/2019 </version>
public class CharacterMovement : MonoBehaviour {   
    private CharacterController characterController;

    [Header("Speed Settings")]
    public float speedLimit = 40f;
    public float[] trackLimits = new float[4];

    [Header("Button Settings")]
    public string verticalAxis;
    [HideInInspector] public string horizontalAxis;
    public string horizontalAxisName;
    public string invertAxisName;
    public string jumpButton;
    public float deadZone = 0.2f;
    [HideInInspector] public bool invert = false;

    [Header("Movement Curves")]
    public AnimationCurve forwardVelocity;
    [HideInInspector] public float forwardT;
    public float forwardTimePeriod;
    public Vector2 inputAxis;
    private Vector3 rotation = Vector3.zero;



    private Vector3 moveDirection = Vector3.zero;
    public float jumpHeight;
    public float gravity;
    public float maxSpeed;
    public float turnSpeed;

    private int jumpsLeft = 1;
    
    /// <summary>
    /// Start is called upon the first frame.
    /// In CharacterMovement, it initializes a CharacterController.
    /// </summary>
    void Start() {
        characterController = GetComponent<CharacterController>();
    }

    void Update() {
        if (characterController.isGrounded) { 
            groundedJump();
        } else {
            secondJump();
        }

        setInputAxis();

        generateVelocity();
        generateTurn();
        applyGravity();
        checkTerrain(4f);
        checkForInvert();

        applyAllInputs();
        

        sceneReset();

        
    }

    void OnControllerColliderHit(ControllerColliderHit hit) {
        if (hit.gameObject.layer == 8) {
            jumpsLeft = 1;
        }
        moveDirection.y = 0f;
    }

    /// <summary>
    /// Generate a Character Controller velocity value based on player inputs.
    /// </summary>
    private void generateVelocity() {
        if (inputAxis.y > deadZone && forwardT < 1f) {
            forwardT += (Time.deltaTime / forwardTimePeriod);
        } else if (inputAxis.y > deadZone && forwardT > 1f) {
            forwardT = 1f;
        } else if (inputAxis.y < -deadZone && forwardT > 0) {
            forwardT -= (Time.deltaTime * 7 / forwardTimePeriod);
        } else if (inputAxis.y < -deadZone && forwardT < 0) {
            forwardT = 0;
        } else if (forwardT > 0) {
            forwardT -= (Time.deltaTime * 4 / forwardTimePeriod);
        } else {
            forwardT = 0;
        }
        
        Vector3 temp = moveDirection;
        moveDirection = gameObject.transform.forward * forwardVelocity.Evaluate(forwardT) * maxSpeed;
        moveDirection.y = temp.y;
    }

    /// <summary>
    /// Allows the Character to Jump when Grounded.
    /// </summary>
    private void groundedJump() {
        if (Input.GetButton(jumpButton)) {
            moveDirection.y = jumpHeight;
        }
    }

    /// <summary>
    /// Allows the Character to Jump when in the Air.
    /// </summary>
    private void secondJump() {
        if (jumpsLeft > 0 && Input.GetButtonDown(jumpButton)) {
            moveDirection.y = jumpHeight;
            jumpsLeft--;
        }
    }

    /// <summary>
    /// Generate a Character Controller rotation value based on player inputs.
    /// </summary>
    private void generateTurn() {
        if (inputAxis.x > deadZone || inputAxis.x < -deadZone) {
            rotation = new Vector3(0f, inputAxis.x, 0f);
            Debug.Log("Horizontal: " + inputAxis.x);
        } else {
            rotation = Vector3.zero;
            Debug.Log("NOT TURNING");
        }
        rotation *= turnSpeed;
        
    }

    /// <summary>
    /// Applies localized gravity to the Character.
    /// </summary>
    private void applyGravity() {
        moveDirection.y -= gravity * Time.deltaTime;
    }

    /// <summary>
    /// Applies rotation and velocity values to the character.
    /// </summary>
    private void applyAllInputs() {
        characterController.Move(moveDirection * Time.deltaTime);
        characterController.transform.Rotate(rotation);
    }

    /// <summary>
    /// Sets the InputAxis Vector 2 based on Player Inputs.
    /// </summary>
    private void setInputAxis() {
        inputAxis = new Vector2(Input.GetAxis(horizontalAxis), Input.GetAxis(verticalAxis));
    }

    /// <summary>
    /// Resets the Scene with the R Key.
    /// </summary>
    private void sceneReset() {
        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    /// <summary>
    /// Sets the Speed Limit based on the terrain type.
    /// </summary>
    /// <param> rayLength is the length of the raycast. </param>
    private void checkTerrain(float rayLength) {
        Ray roadCheck = new Ray(this.transform.position, Vector3.down);
        RaycastHit roadTypeHit;
        Debug.DrawRay(this.transform.position, Vector3.down, Color.cyan, rayLength);

        if (Physics.Raycast(roadCheck, out roadTypeHit, rayLength) && roadTypeHit.collider.tag.Equals("Road")) {
            speedLimit = trackLimits[0];
            // Debug.Log("ROAD");
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, rayLength) && roadTypeHit.collider.tag.Equals("Sand")) {
            speedLimit = trackLimits[1];
            // Debug.Log("SAND");
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, rayLength) && roadTypeHit.collider.tag.Equals("Grass")) {
            speedLimit = trackLimits[2];
            // Debug.Log("GRASS");
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, rayLength) && roadTypeHit.collider.tag.Equals("Water")) {
            speedLimit = trackLimits[3];
            // Debug.Log("WATER");
        }

        maxSpeed = Mathf.Lerp(maxSpeed, speedLimit, 0.6f);
    }

    private void checkForInvert() {
        if (!invert) {
            horizontalAxis = horizontalAxisName;
        } else {
            horizontalAxis = invertAxisName;
        }
    }
}