using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private float angularT;
    public float angularTimePeriod;
    public Vector2 inputAxis;



    private Vector3 moveDirection;
    public float jumpHeight;
    public float gravity;
    public float maxSpeed;

    private int jumpsLeft = 2;
    

    void Start() {
        characterController = gameObject.GetComponent<CharacterController>();
    }

    void Update() {
        GroundedMovement();
        inputAxis = new Vector2(Input.GetAxis(horizontalAxis), Input.GetAxis(verticalAxis));
        // Debug.Log(inputAxis);
    //     // Max Velocity is based on the Current Track Type
    //     maxVelocity = Mathf.Lerp(maxVelocity, surfaceSpeeds[(int) currentSurfaceType], Time.deltaTime * velocitySmooth);

    //     // If the GameObject is grounded, it can accelerate forward.
    //     if (!inAir) {
    //         if (Input.GetKey(forwardKey) && currentTime < 1f) { // Keep in mind forward doesn't change velocity, but time.
    //             currentTime += Time.deltaTime / timePeriod; // It takes TimePeriod number of seconds to reach full speed.
    //         } else if (Input.GetKey(forwardKey) && currentTime >= 1f) {
    //             currentTime = 1f;
    //         }
            
    //         if (Input.GetKey(brakeKey) && currentTime > 0f) {
    //             currentTime -= Time.deltaTime / timePeriod; // It takes TimePeriod number of seconds to reach 0 speed.
    //         } else if (Input.GetKey(brakeKey) && currentTime <= 0f) {
    //             currentTime = 0f;
    //         }
    //         Debug.Log("GROUNDED");

    //         if (Input.GetKeyDown(KeyCode.Space)) {
    //             Debug.Log("JUMP");
                
    //             moveDirection.y = jumpSpeed;
    //         }
    //     }
        
    //     if (currentTime > 0f && !Input.GetKey(forwardKey)) { // If the forward key isn't being pressed, deacceleration is applied.
    //         currentTime = Mathf.Lerp(currentTime, 0f, 0.4f);
    //     } else if (currentTime < 0f) {
    //         currentTime = 0f;
    //     }

    //     currentVelocity = maxVelocity * velocityCurve.Evaluate(currentTime); // The current velocity is based on a point in the animation curve based on time.
    //     moveDirection = currentVelocity * gameObject.transform.forward;
    //     Debug.Log("MOVING:" + moveDirection);

    //     //moveDirection.y -= gravity * Time.deltaTime;

    //     cc.Move(moveDirection * Time.deltaTime);


    //     // Set Velocity based on Current Velocity
    //     // cc


    //     // rb.velocity = Vector3.Lerp(rb.velocity, gameObject.transform.forward * currentVelocity, Time.deltaTime * velocitySmooth);
    //     // rb.angularVelocity = Vector3.zero;
    // }

    // void OnCollisionEnter(Collision collision) {
    //     if (collision.gameObject.tag == "Wall") { // Lose velocity rapidly, upon hitting a wall.
    //         currentTime = Mathf.Lerp(currentTime, 0f, 10f * Time.deltaTime);
    //         Debug.Log("Hitting Wall");
    //     }
    //     inAir = false; // Player is grounded upon collision. (This is bad because you can jump on vertical walls.)
    // }
    
    // void OnCollisionExit(Collision collide) {
    //     inAir = true;
    }

    /// <summary>
    /// Allows the player to move while Grounded.
    /// </summary>
    private void GroundedMovement() {
        if (this.characterController.isGrounded) { // What player can do when grounded
            jumpsLeft = 2; // Resets Double Jump (WONT WORK WITH MOUNTAIN)

            if (inputAxis.y > deadZone && forwardT < 1f) {
                forwardT += (Time.deltaTime / forwardTimePeriod);
                Debug.Log("accelrating");
            } else if (inputAxis.y > deadZone && forwardT > 1f) {
                forwardT = 1f;
                Debug.Log("maxSpeed");
            } else if (inputAxis.y < -deadZone && forwardT > 0) {
                forwardT -= (Time.deltaTime * 5 / forwardTimePeriod);
                Debug.Log("braking");
            } else if (inputAxis.y < -deadZone && forwardT < 0) {
                forwardT = 0;
                Debug.Log("stopped");
            } else if (forwardT > 0) {
                forwardT -= (Time.deltaTime * 2 / forwardTimePeriod);
                Debug.Log("braking");
            } else {
                forwardT = 0;
                Debug.Log("stopped");
            }

        } else { // What player can do in the air
            // gravity *= 2;
        }



        // if (Input.GetKeyDown(jumpKey) && jumpsLeft > 0) {
        //     jumpsLeft--; // You have one last jump left in the air.
        //     moveDirection.y = jumpHeight;
        // }

        // Debug.Log("ForwardT: " + forwardT);
        moveDirection = gameObject.transform.forward * forwardVelocity.Evaluate(forwardT) * maxSpeed;
        moveDirection.y -= gravity * Time.deltaTime; // Adds effect of gravity to the player

        Debug.Log("MOVE DIRECTION: " + moveDirection);
        characterController.Move(moveDirection * Time.deltaTime);
    }
}
