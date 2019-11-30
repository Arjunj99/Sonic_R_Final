﻿using System.Collections;
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


    [Header("Movement Curves")]
    public AnimationCurve forwardVelocity;
    public AnimationCurve angularVelocity;
    private float forwardT;
    public float forwardTimePeriod;
    private float angularT = 0.5f;
    public float angularTimePeriod;
    public Vector2 inputAxis;
    private Vector3 rotation = Vector3.zero;



    private Vector3 moveDirection = Vector3.zero;
    public float jumpHeight;
    public float gravity;
    public float maxSpeed;
    public float turnSpeed;
    public float turnSmooth;

    private int jumpsLeft = 1;
    
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update() {
        if (characterController.isGrounded) {
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
            moveDirection = gameObject.transform.forward * forwardVelocity.Evaluate(forwardT) * maxSpeed;


            if (Input.GetButton("Jump")) {
                moveDirection.y = jumpHeight;
            }
            // jumpsLeft = 1;
        } else {
            if (jumpsLeft > 0 && Input.GetButtonDown(jumpButton)) {
                moveDirection.y = jumpHeight;
                jumpsLeft--;
            }
        }

        
        rotation = new Vector3(0f, Input.GetAxis(horizontalAxis), 0f);
        rotation *= turnSpeed;
        // Debug.Log("Horizontal:" + rotation);

        // Apply gravity
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);
        characterController.transform.Rotate(rotation);
    


        if (Input.GetKey(KeyCode.R))
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        inputAxis = new Vector2(Input.GetAxis(horizontalAxis), Input.GetAxis(verticalAxis));
    

        float trackTypeDistance = 4f;

        Ray roadCheck = new Ray(this.transform.position, Vector3.down);
        RaycastHit roadTypeHit;
        Debug.DrawRay(this.transform.position, Vector3.down, Color.cyan, trackTypeDistance);

        if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Road")) {
            maxSpeed = 40f;
            Debug.Log("ROAD");
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Sand")) {
            maxSpeed = 30f;
            Debug.Log("SAND");
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Grass")) {
            maxSpeed = 25f;
            Debug.Log("GRASS");
        } else if (Physics.Raycast(roadCheck, out roadTypeHit, trackTypeDistance) && roadTypeHit.collider.tag.Equals("Water")) {
            maxSpeed = 15f;
            Debug.Log("WATER");
        }

    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.layer == 8) {
            jumpsLeft = 1;
        }
    }
}


















//     void Start() {
//         characterController = gameObject.GetComponent<CharacterController>();
//     }

//     void Update() {
//         if (Input.GetKey(KeyCode.R))
//             SceneManager.LoadScene(SceneManager.GetActiveScene().name);

//         GroundedMovement();
//         inputAxis = new Vector2(Input.GetAxis(horizontalAxis), Input.GetAxis(verticalAxis));
//     }

//     /// <summary>
//     /// Allows the Player to Move
//     /// </summary>
//     private void GroundedMovement() {
//         if (this.characterController.isGrounded) { // What player can do when grounded
//             Movement(); // Allows for movement while grounded

//             if (Input.GetButton(jumpButton)) {
//                 moveDirection.y = jumpHeight;
//             }
            
//             gravity = 10f;
//         } else {
//             gravity += 10f;
//         }

//         rotation = new Vector3(0f, Input.GetAxis(horizontalAxis), 0f);
//         rotation *= turnSpeed;

//         moveDirection = gameObject.transform.forward * forwardVelocity.Evaluate(forwardT) * maxSpeed;

//         moveDirection.y -= gravity * Time.deltaTime;

//         // Move the controller
//         characterController.Move(moveDirection * Time.deltaTime);
//         characterController.transform.Rotate(rotation);
//     }


//     private void Movement() {
//         if (inputAxis.y > deadZone && forwardT < 1f) {
//                 forwardT += (Time.deltaTime / forwardTimePeriod);
//             } else if (inputAxis.y > deadZone && forwardT > 1f) {
//                 forwardT = 1f;
//             } else if (inputAxis.y < -deadZone && forwardT > 0) {
//                 forwardT -= (Time.deltaTime * 5 / forwardTimePeriod);
//             } else if (inputAxis.y < -deadZone && forwardT < 0) {
//                 forwardT = 0;
//             } else if (forwardT > 0) {
//                 forwardT -= (Time.deltaTime * 2 / forwardTimePeriod);
//             } else {
//                 forwardT = 0;
//             }
//     }
// }
