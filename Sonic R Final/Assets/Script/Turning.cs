using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turning : MonoBehaviour {
    [Header("Turn Settings Settings")]
    [SerializeField] private float turnIncrement;
    [SerializeField] private float turnMaxSpeed;
    [SerializeField] private float turnLerp;
    [HideInInspector] public float turnSpeed;

    [Header("Button Settings")]
    [SerializeField] private KeyCode leftKey;
    [SerializeField] private KeyCode rightKey;




    // Update is called once per frame
    void Update() {
        if (Input.GetKey(leftKey) && turnSpeed > -turnMaxSpeed) { // Turning GameObject Left
            turnSpeed -= turnIncrement;
        } else if (Input.GetKey(leftKey) && turnSpeed <= -turnMaxSpeed) {
            turnSpeed = -turnMaxSpeed;
        }

        if (Input.GetKey(rightKey) && turnSpeed < turnMaxSpeed) { // Turning GameObject Right
            turnSpeed += turnIncrement;
        } else if (Input.GetKey(rightKey) && turnSpeed >= turnMaxSpeed) {
            turnSpeed = turnMaxSpeed;
        }

        gameObject.transform.Rotate(new Vector3(0f, turnSpeed, 0f));

        turnSpeed = Mathf.Lerp(turnSpeed, 0f, turnLerp * Time.deltaTime); // Breaking force for Turn

    }
}
