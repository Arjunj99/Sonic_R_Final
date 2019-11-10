using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    [Header("Jump Settings")]
    public float jumpHeight;

    [Header("Button Settings")]
    public KeyCode jumpButton;

    private Rigidbody rb;

    private int maxJumps = 2;
    private int jumps = 2;
    private bool grounded = false;



    private bool jump1;
    private bool jump2;



    // Start is called before the first frame update
    void Start() {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(jumpButton)) {
            JumpAction();
        }



        // Ray roadCheck = new Ray(this.transform.position, Vector3.down);
        // RaycastHit hit;
        // Debug.DrawRay(this.transform.position, Vector3.down, Color.cyan, 0.1f);

        // if (Physics.Raycast(roadCheck, out hit, 0.1f)) {
        //     jump1 = true;
        //     jump2 = true;
        //     Debug.Log("On Ground");
        // } 
        // else {
        //     // jump1 = false;
        //     // jump2 = false;
        //     // Debug.Log("Not On Ground");
        // }

        // if (Input.GetKeyDown(jumpButton) && jump1 && jump2) {
        //     rb.AddForce(gameObject.transform.up * jumpHeight, ForceMode.Impulse);
        //     jump1 = false;
        // } else if (Input.GetKeyDown(jumpButton) && !jump1 && jump2) {
        //     rb.AddForce(gameObject.transform.up * jumpHeight, ForceMode.Impulse);
        //     jump2 = false;
        // }



        //     // movement.onTrack = true;
        //     Debug.Log("On Road");
        //     // boat.SetCurrentSpeed(boat.GetCurrentSpeed() + 0.2f);
        // } else {
        //     // movement.onTrack = false;
        // }

        // if (Input.GetKeyDown(jumpButton)) {
        //     rb.AddForce(gameObject.transform.up * jumpHeight, ForceMode.Impulse);
        // }
        
    }

    void JumpAction() {
        if (jumps > 0) {
            rb.AddForce(gameObject.transform.up * jumpHeight, ForceMode.Impulse);
            grounded = false;
            jumps -= 1;
        } if (jumps == 0) {
            return;
        }
    }

    void OnCollisionEnter(Collision collide) {
        jumps = 2;
    }

    //      gameObject.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpforce), ForceMode2D.Impulse);
    //      grounded = false;
    //      jumps = jumps - 1;
    //  }
    //  if (jumps == 0)
    //  {
    //      return;
    //  }
}
