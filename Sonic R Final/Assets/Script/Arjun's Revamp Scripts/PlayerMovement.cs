using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // [Header("Max Speeds (Surfaces)")]
    // [SerializeField] public List<float> surfaceSpeeds = new List<float>(); // List of Speeds based on Surface Type
    // [HideInInspector] public enum trackType {track, sand, grass, water}; // List of Surface Types
    // public trackType currentSurfaceType; // Current Surface Type
    // [HideInInspector] public float currentVelocity;
    // [HideInInspector] public float maxVelocity;
    // [HideInInspector] public float currentTime; // How long the player has been holding down the forward Key
    // public float timePeriod = 2; // How long it takes for player to reach max speed

    // [Header("Velocity Speeds")]
    // public float velocitySmooth; // The value used to lerp between speeds
    // public AnimationCurve velocityCurve; // Animation Curve used to shape acceleration
    // private Rigidbody rb;
    // private CharacterController cc;
    // private bool inAir; // If the GameObject is in the Air

    // [Header("Button Settings")]
    // [SerializeField] private KeyCode forwardKey; // Key for going forward
    // [SerializeField] private KeyCode brakeKey; // Key for braking

    // Vector3 moveDirection;
    // public float jumpSpeed;
    // public float gravity;

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
            jumpsLeft = 2; // Resets Double Jump (WONT WORK WITH MOUNTAIN)
            Movement(); // Allows for movement while grounded
            gravity = 9.81f;
            Jump();
            
        } else { // What player can do in the air
            gravity += gravity * Time.deltaTime;
        }

        

        gameObject.transform.Rotate(new Vector3(0f, angularVelocity.Evaluate(angularT) * turnSpeed, 0f));

        moveDirection = gameObject.transform.forward * forwardVelocity.Evaluate(forwardT) * maxSpeed;
        
        moveDirection.y -= gravity; // Adds effect of gravity to the player

        // Debug.Log("MOVE DIRECTION: " + moveDirection);
        
        Turn();
        
        characterController.Move(moveDirection * Time.deltaTime);
        Debug.Log(moveDirection);
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

    private void Turn() {
        if (inputAxis.x > deadZone && angularT < 1f) {
            angularT += (Time.deltaTime / angularTimePeriod);
        } else if (inputAxis.x > deadZone && angularT > 1f) {
            angularT = 1f;
        } else if (inputAxis.x < -deadZone && angularT > 0) {
            angularT -= (Time.deltaTime * 5 / angularTimePeriod);
        } else if (inputAxis.x < -deadZone && angularT < 0) {
            angularT = 0;
        } else if (angularT > 0.51f || angularT < 0.49f) {
            angularT = Mathf.Lerp(angularT, 0.5f, turnSmooth * Time.deltaTime);
        } else {
            angularT = 0.5f;
        }
    }

    private void Jump() {
        if (Input.GetButton(jumpButton)) {
                moveDirection.y = jumpHeight;
        }
    }
}
