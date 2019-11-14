using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    [Header("Max Speeds (Surfaces)")]
    [SerializeField] private List<float> surfaceSpeeds = new List<float>();

    [HideInInspector] public enum trackType {track, sand, grass, water};
    public trackType currentSurfaceType;
    [HideInInspector] public float currentVelocity;
    [HideInInspector] public float maxVelocity;
    [HideInInspector] public float currentTime;

    [Header("Velocity Speeds")]
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
        maxVelocity = Mathf.Lerp(maxVelocity, surfaceSpeeds[(int) currentSurfaceType], Time.deltaTime * 3f);
        

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
            currentTime -= Time.deltaTime / 5;
        } else if (currentTime < 0f) {
            currentTime = 0f;
        }

        currentVelocity = maxVelocity * velocityCurve.Evaluate(currentTime);
     // Debug.Log("Current Velocity: " + currentVelocity);

        // Debug.Log("Current Velocity: " + currentVelocity);


        rb.velocity = Vector3.Lerp(rb.velocity, gameObject.transform.forward * currentVelocity, Time.deltaTime * velocitySmooth);

        // if (Input.GetKey(KeyCode.Z)) {
        //     rb.AddForce(gameObject.transform.up * 2, ForceMode.Impulse);
        // }
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Wall") {
            currentTime = Mathf.Lerp(currentTime, 0f, 5f * Time.deltaTime);
            Debug.Log("Hitting Wall");
        }
    }
}
