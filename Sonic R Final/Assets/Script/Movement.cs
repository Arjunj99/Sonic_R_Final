using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Allow a GameObject with this script to Move Forward with a velocity based on the current Track.
/// </summary>
/// <author> Arjun Jaishankar </author>
/// <version> 11/21/2019 </version>
public class Movement : MonoBehaviour {
    [Header("Max Speeds (Surfaces)")]
    [SerializeField] public List<float> surfaceSpeeds = new List<float>(); // List of Speeds based on Surface Type
    [HideInInspector] public enum trackType {track, sand, grass, water}; // List of Surface Types
    public trackType currentSurfaceType; // Current Surface Type
    [HideInInspector] public float currentVelocity;
    [HideInInspector] public float maxVelocity;
    [HideInInspector] public float currentTime; // How long the player has been holding down the forward Key
    public float timePeriod = 2; // How long it takes for player to reach max speed

    [Header("Velocity Speeds")]
    public float velocitySmooth; // The value used to lerp between speeds
    public AnimationCurve velocityCurve; // Animation Curve used to shape acceleration
    private Rigidbody rb;
    private bool inAir; // If the GameObject is in the Air

    [Header("Button Settings")]
    [SerializeField] private KeyCode forwardKey; // Key for going forward
    [SerializeField] private KeyCode brakeKey; // Key for braking



    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update() {
        // Max Velocity is based on the Current Track Type
        maxVelocity = Mathf.Lerp(maxVelocity, surfaceSpeeds[(int) currentSurfaceType], Time.deltaTime * velocitySmooth);

        // If the GameObject is grounded, it can accelerate forward.
        if (!inAir) {
            if (Input.GetKey(forwardKey) && currentTime < 1f) { // Keep in mind forward doesn't change velocity, but time.
                currentTime += Time.deltaTime / timePeriod; // It takes TimePeriod number of seconds to reach full speed.
            } else if (Input.GetKey(forwardKey) && currentTime >= 1f) {
                currentTime = 1f;
            }
            
            if (Input.GetKey(brakeKey) && currentTime > 0f) {
                currentTime -= Time.deltaTime / timePeriod; // It takes TimePeriod number of seconds to reach 0 speed.
            } else if (Input.GetKey(brakeKey) && currentTime <= 0f) {
                currentTime = 0f;
            }
        }
        
        if (currentTime > 0f && !Input.GetKey(forwardKey)) { // If the forward key isn't being pressed, deacceleration is applied.
            currentTime = Mathf.Lerp(currentTime, 0f, 0.4f);
        } else if (currentTime < 0f) {
            currentTime = 0f;
        }

        currentVelocity = maxVelocity * velocityCurve.Evaluate(currentTime); // The current velocity is based on a point in the animation curve based on time.


        // Set Velocity based on Current Velocity
        rb.velocity = Vector3.Lerp(rb.velocity, gameObject.transform.forward * currentVelocity, Time.deltaTime * velocitySmooth);
        rb.angularVelocity = Vector3.zero;
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Wall") { // Lose velocity rapidly, upon hitting a wall.
            currentTime = Mathf.Lerp(currentTime, 0f, 10f * Time.deltaTime);
            Debug.Log("Hitting Wall");
        }
        inAir = false; // Player is grounded upon collision. (This is bad because you can jump on vertical walls.)
    }
    
    void OnCollisionExit(Collision collide) {
        inAir = true;
    }
}
