using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour {
    [Header("Turn Settings Settings")]
    [SerializeField] private float turnIncrement;
    [SerializeField] private float turnMaxSpeed;
    [SerializeField] private float turnLerp;
    [HideInInspector] public float turnSpeed;
    public AnimationCurve rotationCurve;
    private float currentTime;
    public float timePeriod;

    [Header("Button Settings")]
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private KeyCode rightKey;

    public GameObject hinge;


    void Start() {
        currentTime = 0.5f;
    }

    // Update is called once per frame
    void Update() {
        if ((Input.GetKey(rightKey) && currentTime < 1f)) {
            currentTime += Time.deltaTime / timePeriod;
        } else if (Input.GetKey(rightKey) && currentTime >= 1f) {
            currentTime = 1f;
        }

        if ((Input.GetKey(leftKey) && currentTime > 0f)) {
            currentTime -= Time.deltaTime / timePeriod;
        } else if (Input.GetKey(leftKey) && currentTime <= 0f) {
            currentTime = 0f;
        }



        // if (currentTime > 0.5f && !(Input.GetKey(leftKey) && Input.GetKey(rightKey))) {
        //     currentTime -= Time.deltaTime / (2 * timePeriod);
        // } else if (currentTime < 0.5f && !(Input.GetKey(leftKey) && Input.GetKey(rightKey))) {
        //     currentTime += Time.deltaTime / (2 * timePeriod);
        // }


        // if (Input.GetKey(leftKey) && turnSpeed > -turnMaxSpeed) { // Turning GameObject Left
        //     turnSpeed -= turnIncrement;
        // } else if (Input.GetKey(leftKey) && turnSpeed <= -turnMaxSpeed) {
        //     turnSpeed = -turnMaxSpeed;
        // }

        // if (Input.GetKey(rightKey) && turnSpeed < turnMaxSpeed) { // Turning GameObject Right
        //     turnSpeed += turnIncrement;
        // } else if (Input.GetKey(rightKey) && turnSpeed >= turnMaxSpeed) {
        //     turnSpeed = turnMaxSpeed;
        // }

        gameObject.transform.Rotate(new Vector3(0f, turnMaxSpeed * rotationCurve.Evaluate(currentTime), 0f));

        currentTime = Mathf.Lerp(currentTime, 0.5f, Time.deltaTime * 3);



        // gameObject.transform.Rotate(new Vector3(0f, turnSpeed, 0f));
        // hinge.transform.Rotate(new Vector3(0f, turnSpeed, 0f));

        // turnSpeed = Mathf.Lerp(turnSpeed, 0f, turnLerp * Time.deltaTime); // Breaking force for Turn

    }
}
