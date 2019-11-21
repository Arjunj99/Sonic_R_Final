using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Allow a GameObject with this script to Jump using Force.
/// </summary>
/// <author> Arjun Jaishankar </author>
/// <version> 11/21/2019 </version>
public class Jump : MonoBehaviour {
    [Header("Jump Settings")]
    public float jumpHeight;
    private Rigidbody rb;
    private int jumps = 2;
    private bool grounded = false;

    [Header("Button Settings")]
    public KeyCode jumpButton;

    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(jumpButton)) {
            JumpAction();
        }
    }

    void OnCollisionEnter(Collision collide) {
        jumps = 2; // Resets Jumps upon touching the Ground
    }

    /// <summary>
    /// Adds a vertical force to the GameObject if it meets Double Jump Requirements.
    /// </summary>
    void JumpAction() {
        if (jumps > 0) {
            rb.AddForce(gameObject.transform.up * jumpHeight, ForceMode.Impulse);
            grounded = false;
            jumps -= 1;
        } if (jumps == 0) {
            return;
        }
    }
}
