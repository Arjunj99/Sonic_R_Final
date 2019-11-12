using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [Header("Max Speeds (Surfaces)")]
    [SerializeField] private List<float> surfaceSpeeds = new List<float>();
    // [SerializeField] private float trackMaxSpeed;
    // [SerializeField] private float sandMaxSpeed;
    // [SerializeField] private float grassMaxSpeed;
    // [SerializeField] private float waterMaxSpeed;

    // [Header("Max Speeds (Surfaces)")]
    [HideInInspector] public enum trackType {track, sand, grass, water};
    public trackType currentTrackType;
    [HideInInspector] public float currentVelocity;
    [HideInInspector] public float maxVelocity;
    [HideInInspector] public float currentTime;
    public float velocitySmooth;



    public AnimationCurve velocityCurve;

    [Header("Button Settings")]
    [SerializeField] private KeyCode forwardKey;
    [SerializeField] private KeyCode brakeKey;

    private Rigidbody rb;


    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        maxVelocity = surfaceSpeeds[(int) currentTrackType];

        if (Input.GetKey(forwardKey) && currentTime < 1f) {
            currentTime += Time.deltaTime / 2;
        } else if (Input.GetKey(forwardKey) && currentTime >= 1f) {
            currentTime = 1f;
        }
        
        if (Input.GetKey(brakeKey) && currentTime > 0f) {
            currentTime -= Time.deltaTime / 2;
        } else if (Input.GetKey(brakeKey) && currentTime <= 0f) {
            currentTime = 0f;
        }

        if (currentTime > 0f) {
            currentTime -= Time.deltaTime / 20;
        } else if (currentTime < 0f) {
            currentTime = 0f;
        }

        currentVelocity = maxVelocity * velocityCurve.Evaluate(currentTime);
       // Debug.Log("Current Velocity: " + currentVelocity);

        rb.velocity = Vector3.Lerp(rb.velocity, gameObject.transform.forward * currentVelocity, Time.deltaTime * velocitySmooth);

        // rb.velocity += gameObject.transform.forward * velocityMod;
        // rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, 0.1f);


        // if (Input.GetKey(forwardKey) && currentVelocity < maxVelocity) {
        //     currentVelocity = velocityCurve.Evaluate
        // } else if (Input.GetKey(forwardKey) && currentVelocity >= maxVelocity) {
        //     currentVelocity = maxVelocity;
        // } else if (currentVelocity > 0) {

        // }



        // if (currentTrackType == trackType.track) {
        //     maxVelocity = surfaceSpeeds[trackType.track];
        // }

        // if (onTrack) { // If the GameObject is on Track Terrain, it moves faster.
        //     maxVelocity = 5f;
        // } else {
        //     maxVelocity = 2.5f;
        // }

        


        // if (Input.GetKey(KeyCode.W) && velocityMod < maxVelocity) {
        //     velocityMod += 0.02f;
        // } else if (velocityMod > 0) {
        //     velocityMod -= 0.01f;
        // }

        // // if (Input.GetKey(KeyCode.D)) {
        // //     gameObject.transform.Rotate(new Vector3(0,1,0));
        // // } else if (Input.GetKey(KeyCode.A)) {
        // //     gameObject.transform.Rotate(new Vector3(0,-1,0));
        // // }

        // if (Input.GetKey(KeyCode.S)) {
        //     if (rb.velocity.magnitude > 2.0f)
        //         rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, 0.3f);
        //     else {
        //         rb.velocity = Vector3.zero;
        //         velocityMod = 0;
        //         Debug.Log("Instant Break");
        //     }
                
        // }

        if (Input.GetKey(KeyCode.Z)) {
            rb.AddForce(gameObject.transform.up * 2, ForceMode.Impulse);
        }

        // rb.velocity += gameObject.transform.forward * velocityMod;
        // rb.velocity = Vector3.Lerp(rb.velocity, Vector3.zero, 0.1f);

        // Debug.Log(rb.velocity.magnitude);

        // if (rb.velocity.z > 0) {
        //     rb.velocity -= gameObject.transform.forward * -0.8f;
        //     Debug.Log("Breaking");
        // }
            
        
        
        // transform.position += transform.forward * velocity / 500;
    }
}
